using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.Models;
using TaxiService.TaxiDataSetTableAdapters;
using static TaxiService.Constants;
using static TaxiService.Utilities;

namespace TaxiService.Forms
{
    public partial class CarCategoryForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public CarCategoryForm()
        {
            InitializeComponent();
            edit = false;
        }

        public CarCategoryForm(CarCategory carCategory)
        {
            InitializeComponent();
            edit = true;

            id = carCategory.CarCategoryId;
            category_nameTextBox.Text = carCategory.CategoryName;
            max_passengers_numberTextBox.Text = carCategory.MaxPassengersNumber.ToString();
            kilometer_priceTextBox.Text = carCategory.KilometerPrice.ToString();
        }

        private void CarCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Car_category' table. You can move, or remove it, as needed.
            this.car_categoryTableAdapter.Fill(this.taxiDataSet.Car_category);

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (inputCheck() && MessageBox.Show("Ви підтверджуєте оновлення даних?",
                            "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    car_categoryTableAdapter.UpdateQuery(category_nameTextBox.Text, 
                        Convert.ToInt32(max_passengers_numberTextBox.Text),
                        Convert.ToDouble(kilometer_priceTextBox.Text), id);
                }
                else
                {
                    car_categoryTableAdapter.InsertQuery(category_nameTextBox.Text,
                        Convert.ToInt32(max_passengers_numberTextBox.Text),
                        Convert.ToDouble(kilometer_priceTextBox.Text));
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void max_passengers_numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            intInput(sender, e);
        }

        private void kilometer_priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(sender, e);
        }

        private bool inputCheck()
        {
            if (category_nameTextBox.Text != "" && max_passengers_numberTextBox.Text != ""
                && kilometer_priceTextBox.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
