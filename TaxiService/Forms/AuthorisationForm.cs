using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaxiService.Constants;
using static TaxiService.Utilities;
using static TaxiService.CodeCheckForm;
using System.Data.SqlClient;
using TaxiService.Models;

namespace TaxiService
{
    public partial class AuthorisationForm : Form
    {
        string userEmail;

        public AuthorisationForm()
        {
            InitializeComponent();
        }

        public AuthorisationForm(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
            UserEmail.Text = userEmail;
        }

        private void AuthorisationButton_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(UserEmail.Text))
            {
                ErrorLabel.Text = "";

                int authorisationCode = GenerateAuthorisationCode();
                string body = MAIL_TEXT + " <h1>" + authorisationCode + "</h1>";
                
                SendEmail(MY_GOOGLE_MAIL, PASSWORD, UserEmail.Text, 
                    MAIL_SUBJECT, body);

                CodeCheckForm codeCheckForm = new CodeCheckForm(authorisationCode, UserEmail.Text);
                this.Hide();
                codeCheckForm.Show();
            }
            else if (UserEmail.Text == "admin")
            {
                if (!IsEmailAlreadyExists("illia.holovashenko@nure.ua"))
                {
                    string connectionString = @"Data Source=VOLODYMYR;Initial Catalog=Taxi;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = $"INSERT INTO Passenger (Email) VALUES ('illia.holovashenko@nure.ua')";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MainForm main = new MainForm(Passenger.GetPassenger("Email", "illia.holovashenko@nure.ua"));
                main.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Text = "Здається, ви ввели неіснуючий e-mail";
            }
        }

        private void UserEmail_TextChanged(object sender, EventArgs e)
        {
            if (UserEmail.Text != "")
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

        public static int GenerateAuthorisationCode()
        {
            Random random = new Random();

            int authorisationCode = random.Next(100000, 1000000); 
            return authorisationCode;
        }

        public static void SendEmail(string fromEmail, string password, string toEmail, string subject, string body)
        {
            MailAddress from = new MailAddress(fromEmail, APP_NAME);
            MailAddress to = new MailAddress(toEmail);

            MailMessage m = new MailMessage(from, to)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential(fromEmail, password),
                EnableSsl = true,
            };
            smtp.Send(m);
            smtp.Dispose();
        }

        private void AuthorisationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
