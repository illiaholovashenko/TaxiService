using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.Models;
using static TaxiService.Utilities;
using static TaxiService.Constants;
using static TaxiService.Models.Driver;
using System.Data.SqlClient;
using System.Data.Entity;

namespace TaxiService.Forms
{
    public partial class DriverSelectionForm : Form
    {
        Passenger passenger;
        Order order;
        string DriverPhone;

        public DriverSelectionForm(Passenger passenger, Order order)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.order = order;
        }

        public DriverSelectionForm(Passenger passenger, Order order, string DriverPhone)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.order = order;
            this.DriverPhone = DriverPhone;
        }

        private void DriverSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DriverSelectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.taxiDataSet.Driver);
            SetDBView(driversDataGridView, DRIVER_DB_INIT + DRIVER_DB_INIT_GROUP_BY);

            if (DriverPhone != null)
            {
                foreach (DataGridViewRow row in driversDataGridView.Rows)
                {
                    string driverPhoneInRow = row.Cells["Phone_number"].Value.ToString();

                    if (driverPhoneInRow == DriverPhone)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            sortComboBox.SelectedIndex = 0;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(passenger);
            mainForm.Show();
            this.Hide();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseQuery = DRIVER_DB_INIT + DRIVER_DB_INIT_GROUP_BY;
            string orderByColumn = "Rating";

            if (sortComboBox.SelectedIndex == 1)
            {
                orderByColumn = "DATEDIFF(year, Driving_expirience, GETDATE())";
            }
            else if (sortComboBox.SelectedIndex == 2)
            {
                orderByColumn = "DATEDIFF(year, Birth_date, GETDATE())";
            }
            else if (sortComboBox.SelectedIndex == 3)
            {
                orderByColumn = "TotalOrders";
            }

            if (ascRadioButton.Checked)
            {
                SetDBView(driversDataGridView, $"{baseQuery} ORDER BY {orderByColumn} ASC");
            }
            else
            {
                SetDBView(driversDataGridView, $"{baseQuery} ORDER BY {orderByColumn} DESC");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SetDBView(driversDataGridView, $"{DRIVER_DB_INIT} WHERE CONCAT(Driver.First_name, ' ', Driver.Last_name, ' ', Driver.Middle_name) LIKE N'%{searchTextBox.Text}%' {DRIVER_DB_INIT_GROUP_BY};");
        }

        private void driversDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (driversDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = driversDataGridView.SelectedRows[0];
                int driverId = GetDriver("Phone_number", selectedRow.Cells[1].Value.ToString()).DriverId;
                priceLabel.Text = $"Ціна: {Math.Round(order.Price * GetKilometerPriceByDriverId(driverId), 1)} грн";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (driversDataGridView.SelectedRows.Count == 1)
            {
                errorLabel.Text = "";
                DataGridViewRow selectedRow = driversDataGridView.SelectedRows[0];
                int driverId = GetDriver("Phone_number", selectedRow.Cells[1].Value.ToString()).DriverId;
               
                order.DriverId = driverId;
                order.OrderState = STATE_WAITING;
                order.Price = Convert.ToSingle(Math.Round(order.Price * GetKilometerPriceByDriverId(driverId), 1));

                ConfirmationForm confirmationForm = new ConfirmationForm(passenger, order);
                confirmationForm.Show();
                this.Hide();
            }
            else if (driversDataGridView.SelectedRows.Count > 1)
            {
                errorLabel.Text = "Оберіть лише одного водія зі списку!";
            }
            else
            {
                errorLabel.Text = "Оберіть водія зі списку!";
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string query = DRIVER_DB_INIT + " WHERE ";
            string basequery = "";
            if (categoryCheckedListBox.CheckedItems.Count > 0)
            {
                List<string> selectedCategories = new List<string>();
                foreach (var item in categoryCheckedListBox.CheckedItems)
                {
                    selectedCategories.Add(item.ToString());
                }

                basequery += $"Category_name IN (N'{string.Join("', N'", selectedCategories)}')";
            }

            if (ratingCheckedListBox.CheckedItems.Count > 0)
            {
                List<string> selectedRatings = new List<string>();
                foreach (var item in ratingCheckedListBox.CheckedItems)
                {
                    switch (item.ToString())
                    {
                        case "0 - 2":
                            selectedRatings.Add("Rating >= 0 AND Rating <= 2");
                            break;
                        case "2 - 4":
                            selectedRatings.Add("Rating > 2 AND Rating <= 4");
                            break;
                        case "більше 4":
                            selectedRatings.Add("Rating > 4");
                            break;
                    }
                }

                if (selectedRatings.Count > 0)
                {
                    if (!string.IsNullOrEmpty(basequery))
                        basequery += " AND ";
                    basequery += $"({string.Join(" OR ", selectedRatings)})";
                }
            }

            int fromExperience = string.IsNullOrEmpty(fromExperienceTextBox.Text) ? -1 : Convert.ToInt32(fromExperienceTextBox.Text);
            int toExperience = string.IsNullOrEmpty(toExperienceTextBox.Text) ? -1 : Convert.ToInt32(toExperienceTextBox.Text);
            if (fromExperience != -1 && toExperience != -1 &&
                fromExperience <= toExperience)
            {
                inputErrorLabel.Text = "";
                if (!string.IsNullOrEmpty(basequery))
                    basequery += " AND ";
                basequery += $"(DATEDIFF(YEAR, Driving_expirience, GETDATE()) >= {fromExperience} " +
                    $"AND DATEDIFF(YEAR, Driving_expirience, GETDATE()) <= {toExperience})";
            }
            else if (fromExperience == -1 ^ toExperience == -1)
            {
                inputErrorLabel.Text = "Заповніть усі поля";
            }
            else if (fromExperience > toExperience)
            {
                inputErrorLabel.Text = "Значення \"Від\" має бути меншим";
            }
            else
            {
                inputErrorLabel.Text = "";
            }

            if (ageCheckedListBox.CheckedItems.Count > 0)
            {
                List<string> selectedAges = new List<string>();
                foreach (var item in ageCheckedListBox.CheckedItems)
                {
                    switch (item.ToString())
                    {
                        case "молодше 20 років":
                            selectedAges.Add("DATEDIFF(YEAR, Birth_date, GETDATE()) < 20");
                            break;
                        case "20 - 30 років":
                            selectedAges.Add("DATEDIFF(YEAR, Birth_date, GETDATE()) >= 20 AND DATEDIFF(YEAR, Birth_date, GETDATE()) <= 30");
                            break;
                        case "30 - 45 років":
                            selectedAges.Add("DATEDIFF(YEAR, Birth_date, GETDATE()) > 30 AND DATEDIFF(YEAR, Birth_date, GETDATE()) <= 45");
                            break;
                        case "45 - 60 років":
                            selectedAges.Add("DATEDIFF(YEAR, Birth_date, GETDATE()) > 45 AND DATEDIFF(YEAR, Birth_date, GETDATE()) <= 60");
                            break;
                        case "старше 60 років":
                            selectedAges.Add("DATEDIFF(YEAR, Birth_date, GETDATE()) > 60");
                            break;
                    }
                }

                if (selectedAges.Count > 0)
                {
                    if (!string.IsNullOrEmpty(basequery))
                        basequery += " AND ";
                    basequery += $"({string.Join(" OR ", selectedAges)})";
                }
            }
            if (!string.IsNullOrEmpty(basequery))
            {
                SetDBView(driversDataGridView, query + basequery + DRIVER_DB_INIT_GROUP_BY);
            }
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            foreach (int checkedIndex in categoryCheckedListBox.CheckedIndices.OfType<int>().ToList())
            {
                categoryCheckedListBox.SetItemChecked(checkedIndex, false);
            }
            foreach (int checkedIndex in ratingCheckedListBox.CheckedIndices.OfType<int>().ToList())
            {
                ratingCheckedListBox.SetItemChecked(checkedIndex, false);
            }
            foreach (int checkedIndex in ageCheckedListBox.CheckedIndices.OfType<int>().ToList())
            {
                ageCheckedListBox.SetItemChecked(checkedIndex, false);
            }
            fromExperienceTextBox.Text = "";
            toExperienceTextBox.Text = "";

            SetDBView(driversDataGridView, DRIVER_DB_INIT + DRIVER_DB_INIT_GROUP_BY);
        }

        private void fromExperienceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            intInput(sender, e);
        }

        private void toExperienceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            intInput(sender, e);
        }

        private void descRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sortComboBox_SelectedIndexChanged(sender, e);
        }

        private void ascRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sortComboBox_SelectedIndexChanged(sender, e);
        }
    }
}
