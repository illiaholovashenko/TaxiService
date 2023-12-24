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
using TaxiService.TaxiDataSetTableAdapters;
using static TaxiService.Utilities;
using static TaxiService.Constants;

namespace TaxiService.Forms
{
    public partial class CarForm : Form
    {
        private readonly string id;
        readonly bool edit;


        public CarForm()
        {
            InitializeComponent();
            driverTableAdapter.Fill(taxiDataSet.Driver);
            car_categoryTableAdapter.Fill(taxiDataSet.Car_category);
            edit = false;
        }

        public CarForm(Car car)
        {
            InitializeComponent();
            driverTableAdapter.Fill(taxiDataSet.Driver);
            car_categoryTableAdapter.Fill(taxiDataSet.Car_category);
            edit = true;

            id = car.CarNumber;

            car_numberTextBox.Text = car.CarNumber;
            modelTextBox.Text = car.Model;
            colorTextBox.Text = car.Color;
            production_yearTextBox.Text = car.ProductionYear.ToString();
            driver_idComboBox.SelectedValue = car.DriverId ?? 0;
            car_category_idComboBox.SelectedValue = car.CarCategoryId ?? 0;

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

            int selectedDriver = Convert.ToInt32(driver_idComboBox.SelectedValue);
            int selectedCategory = Convert.ToInt32(car_category_idComboBox.SelectedValue);

            // TODO: This line of code loads data into the 'taxiDataSet.Car_category' table. You can move, or remove it, as needed.
            this.car_categoryTableAdapter.Fill(this.taxiDataSet.Car_category);
            // TODO: This line of code loads data into the 'taxiDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.taxiDataSet.Driver);
            // TODO: This line of code loads data into the 'taxiDataSet.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.taxiDataSet.Car);

            driver_idComboBox.SelectedValue = selectedDriver;
            car_category_idComboBox.SelectedValue = selectedCategory;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (inputCheck() && MessageBox.Show("Ви підтверджуєте оновлення даних?",
                            "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    carTableAdapter.UpdateQuery(car_numberTextBox.Text,
                        modelTextBox.Text,
                        colorTextBox.Text,
                        Convert.ToInt32(production_yearTextBox.Text),
                        (driver_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(driver_idComboBox.SelectedValue) : (int?)null,
                        (car_category_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(car_category_idComboBox.SelectedValue) : (int?)null);
                }
                else
                {
                    carTableAdapter.InsertQuery(car_numberTextBox.Text,
                        modelTextBox.Text,
                        colorTextBox.Text,
                        Convert.ToInt32(production_yearTextBox.Text),
                        (driver_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(driver_idComboBox.SelectedValue) : (int?)null,
                        (car_category_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(car_category_idComboBox.SelectedValue) : (int?)null);
                }
                Close();
            }
            else if (!inputCheck())
            {
                ErrorLabel.Text = ERROR_INPUT;
            }
            else
            {
                ErrorLabel.Text = "";
            }
        }

        private void production_yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            intInput(sender, e);
        }

        private bool inputCheck()
        {
            if (car_numberTextBox.Text != "" && modelTextBox.Text != ""
                && colorTextBox.Text != "" && production_yearTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
