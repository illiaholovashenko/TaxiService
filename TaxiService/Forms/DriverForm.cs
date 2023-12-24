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
    public partial class DriverForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public DriverForm()
        {
            InitializeComponent();
            edit = false;
        }

        public DriverForm(Driver driver)
        {
            InitializeComponent();
            edit = true;

            id = driver.DriverId;
            first_nameTextBox.Text = driver.FirstName;
            last_nameTextBox.Text = driver.LastName;
            middle_nameTextBox.Text = driver.MiddleName;

            phone_numberTextBox.Text = driver.PhoneNumber;
            cityTextBox.Text = driver.City;
            ratingTextBox.Text = driver.Rating.ToString();
            driving_expirienceDateTimePicker.Value = driver.DrivingExperience;
            registration_dateDateTimePicker.Value = driver.RegistrationDate;
            emailTextBox.Text = driver.Email;
            birth_dateDateTimePicker.Value = driver.BirthDate;
        }



        private void DriverForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.taxiDataSet.Driver);

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (inputCheck() && MessageBox.Show("Ви підтверджуєте оновлення даних?",
                            "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (edit)
                {
                    driverTableAdapter.UpdateQuery(first_nameTextBox.Text, 
                        last_nameTextBox.Text, middle_nameTextBox.Text,
                        phone_numberTextBox.Text, cityTextBox.Text, 
                        (ratingTextBox.Text != "") ? Convert.ToDouble(ratingTextBox.Text) : (double?)null, 
                        driving_expirienceDateTimePicker.Value.ToString(), 
                        registration_dateDateTimePicker.Value.ToString(), 
                        (emailTextBox.Text != "") ? emailTextBox.Text : null, 
                        birth_dateDateTimePicker.Value.ToString(), id);
                } 
                else
                {
                    driverTableAdapter.InsertQuery(first_nameTextBox.Text,
                        last_nameTextBox.Text, middle_nameTextBox.Text,
                        phone_numberTextBox.Text, cityTextBox.Text,
                        (ratingTextBox.Text != "") ? Convert.ToDouble(ratingTextBox.Text) : (double?)null,
                        driving_expirienceDateTimePicker.Value.ToString(),
                        registration_dateDateTimePicker.Value.ToString(),
                        (emailTextBox.Text != "") ? emailTextBox.Text : null,
                        birth_dateDateTimePicker.Value.ToString());
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

        private void ratingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(sender, e);
        }

        private bool inputCheck()
        {
            if (first_nameTextBox.Text != "" && last_nameTextBox.Text != ""
                && middle_nameTextBox.Text != "" && phone_numberTextBox.Text != "" &&
                cityTextBox.Text != "" && (driving_expirienceDateTimePicker.Value <= registration_dateDateTimePicker.Value)
                &&  (DateTime.Now.Subtract(birth_dateDateTimePicker.Value).TotalDays/365) > 18)
            {
                return true;
            }
            return false;
        }
    }
}
