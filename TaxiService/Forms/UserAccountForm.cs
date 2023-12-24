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

namespace TaxiService
{
    public partial class UserAccountForm : Form
    {
        Passenger passenger;
        readonly bool? edit;

        public UserAccountForm(bool edit)
        {
            InitializeComponent();
            this.edit = edit;

            pictureBox1.Visible = false;
            titleLabel.Visible = false;
            CreateButton();
        }
        public UserAccountForm(Passenger passenger, bool edit)
        {
            InitializeComponent();
            this.passenger = passenger;
            this.edit = edit;
            pictureBox1.Visible = false;
            titleLabel.Visible = false;
            CreateButton();
        }

        public UserAccountForm(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            this.passengerTableAdapter.Fill(this.taxiDataSet.Passenger);

            if (passenger != null)
            {
                first_nameTextBox.Text = (passenger.FirstName == null) ? "" : passenger.FirstName;
                last_nameTextBox.Text = (passenger.LastName == null) ? "" : passenger.LastName;
                phone_numberTextBox.Text = (passenger.PhoneNumber == null) ? "" : passenger.PhoneNumber;
                birth_dateDateTimePicker.Value = (passenger.BirthDate == null) ?
                    birth_dateDateTimePicker.MinDate : passenger.BirthDate.Value;
                switch (passenger?.Gender?.ToLower())
                {
                    case "чоловіча":
                        genderComboBox.SelectedIndex = 0;
                        break;
                    case "жіноча":
                        genderComboBox.SelectedIndex = 1;
                        break;
                    default:
                        break;
                }
                emailTextBox.Text = passenger.Email;

            }       
        }


        private void UpdateUserData_Click(object sender, EventArgs e)
        {
            if (inputCheck() && MessageBox.Show("Ви підтверджуєте оновлення даних?",
                "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string gender = null;

                if (genderComboBox.SelectedIndex == 0)
                {
                    gender = "Чоловіча";
                }
                else if (genderComboBox.SelectedIndex == 1)
                {
                    gender = "Жіноча";
                }


                if (edit == null)
                {
                    passengerTableAdapter.UpdateQuery((first_nameTextBox.Text != "") ? first_nameTextBox.Text : null,
                    (last_nameTextBox.Text != "") ? last_nameTextBox.Text : null,
                    (phone_numberTextBox.Text != "") ? phone_numberTextBox.Text : null,
                    (birth_dateDateTimePicker.Value.ToString() == "" || birth_dateDateTimePicker.Value == DateTimePicker.MinimumDateTime) ? null : birth_dateDateTimePicker.Value.ToString(),
                    gender,
                    (emailTextBox.Text != "") ? emailTextBox.Text : null,
                    passenger.PassengerId);

                    MainForm mainForm = new MainForm(Passenger.GetPassenger("Passenger_id", passenger.PassengerId.ToString()));
                    mainForm.Show();
                    this.Hide();
                }
                else if (edit == true)
                {
                    passengerTableAdapter.UpdateQuery((first_nameTextBox.Text != "") ? first_nameTextBox.Text : null,
                    (last_nameTextBox.Text != "") ? last_nameTextBox.Text : null,
                    (phone_numberTextBox.Text != "") ? phone_numberTextBox.Text : null,
                    (birth_dateDateTimePicker.Value.ToString() == "" || birth_dateDateTimePicker.Value == DateTimePicker.MinimumDateTime) ? null : birth_dateDateTimePicker.Value.ToString(),
                    gender,
                    (emailTextBox.Text != "") ? emailTextBox.Text : null,
                    passenger.PassengerId);
                    Close();
                }
                else
                {
                    passengerTableAdapter.InsertQuery((first_nameTextBox.Text != "") ? first_nameTextBox.Text : null,
                    (last_nameTextBox.Text != "") ? last_nameTextBox.Text : null,
                    (phone_numberTextBox.Text != "") ? phone_numberTextBox.Text : null,
                    (birth_dateDateTimePicker.Value.ToString() == "" || birth_dateDateTimePicker.Value == DateTimePicker.MinimumDateTime) ? null : birth_dateDateTimePicker.Value.ToString(),
                    gender,
                    (emailTextBox.Text != "") ? emailTextBox.Text : null);
                    Close();
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(passenger);
            mainForm.Show();
            this.Hide();
        }

        private void CreateButton()
        {
            Button cancelButton = new Button();

            cancelButton.Text = "Скасувати";
            cancelButton.Font = new System.Drawing.Font("Leelawadee UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cancelButton.Size = new System.Drawing.Size(120, 35);
            cancelButton.Location = new System.Drawing.Point(20, 405);


            cancelButton.Click += cancelButton_Click;
            this.Controls.Add(cancelButton);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool inputCheck()
        {
            if (emailTextBox.Text != "" && IsValidEmail(emailTextBox.Text))
            {
                return true;
            }
            return false;
        }
    }
}
