using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.Models;
using static TaxiService.Utilities;

namespace TaxiService
{
    public partial class CodeCheckForm : Form
    {
        int verificationCode;
        string userEmail;

        public CodeCheckForm(int verificationCode, 
            string userEmail)
        {
            InitializeComponent();
            this.verificationCode = verificationCode;
            this.userEmail = userEmail;
            DescriptionLabel.Text += userEmail;
        }

        private void ConfirmCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            intInput(sender, e);
        }

        private void ConfirmCode_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmCode.Text != "")
            {
                AuthorisationButton.Enabled = true;
                AuthorisationButton.BackColor = Color.LightGreen;
            }
            else
            {
                AuthorisationButton.Enabled = false;
                AuthorisationButton.BackColor = Color.Gray;
            }
        }

        private void AuthorisationButton_Click(object sender, EventArgs e)
        {
            if (ConfirmCode.Text.Length == 6 &&
                Convert.ToInt32(ConfirmCode.Text) == verificationCode)
            {
                ErrorLabel.Text = "";
                if (!IsEmailAlreadyExists(userEmail))
                {
                    string connectionString = @"Data Source=VOLODYMYR;Initial Catalog=Taxi;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = $"INSERT INTO Passenger (Email) VALUES ('{userEmail}')";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MainForm main = new MainForm(Passenger.GetPassenger("Email", userEmail));
                main.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Text = "Код неправильний";
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AuthorisationForm authorisationForm = new AuthorisationForm(userEmail);
            this.Hide();
            authorisationForm.Show();
        }

        private void CodeCheckForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static bool IsEmailAlreadyExists(string email)
        {
            string connectionString = @"Data Source=VOLODYMYR;Initial Catalog=Taxi;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM Passenger WHERE Email = '{email}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
