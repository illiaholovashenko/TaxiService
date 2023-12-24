using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaxiService.Utilities;
using static TaxiService.Constants;
using static TaxiService.Models.Order;
using System.Globalization;
using TaxiService.Models;

namespace TaxiService.Forms
{
    public partial class OrdersViewForm : Form
    {
        Passenger passenger;
        public OrdersViewForm(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(passenger);
            mainForm.Show();
            this.Hide();
        }

        private void ordersViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.taxiDataSet.Orders);
            SetDBView(ordersDataGridView, $"{ORDERS_DB_INIT} WHERE Passenger_id = {passenger.PassengerId}");
        }

        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 1)
            {
                ErrorLabel.Text = "";
                DataGridViewRow selectedRow = ordersDataGridView.SelectedRows[0];
                Order order = GetOrder("Orders_id", 
                    ordersTableAdapter.GetOrderIdQuery(Convert.ToDateTime(selectedRow.Cells[2].Value),
                    Convert.ToInt32(selectedRow.Cells[7].Value)).ToString());

                string orderData = $"{order.OrderId.ToString()};" +
                    $"{order.ToString()};" +
                    $"{Passenger.GetPassenger("Passenger_id", order.PassengerId.ToString()).ToString()};" +
                    $"{Driver.GetDriver("Driver_id", order.DriverId.ToString()).ToString()}";

                byte[] reportStream = CreateOrderPdfReport(orderData);

                SendEmailWithAttachment(passenger.Email, MAIL_ORDER_PDF_SUBJECT, MAIL_ORDER_PDF_TEXT,
                    reportStream, $"OrderReport{order.OrderId}.pdf");
            }
            else if (ordersDataGridView.SelectedRows.Count > 1)
            {
                ErrorLabel.Text = "Оберіть лише одну поїздку";
            }
            else
            {
                ErrorLabel.Text = "Оберіть поїздку для отримання звіту";
            }
        }

        private void driverReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 1)
            {
                ErrorLabel.Text = "";
                DataGridViewRow selectedRow = ordersDataGridView.SelectedRows[0];

                Driver driver = Driver.GetDriver("Driver_id", selectedRow.Cells[8].Value.ToString());

                Car car = Car.GetCar("Driver_id", driver.DriverId.ToString());

                string driverData = $"{driver.DriverId.ToString()};{driver.ToString()};{car.ToString()}";

                byte[] reportStream = CreateDriverPdfReport(driverData);

                SendEmailWithAttachment(passenger.Email, MAIL_DRIVER_PDF_SUBJECT, MAIL_DRIVER_PDF_TEXT,
                    reportStream, $"DriverReport{driver.DriverId}.pdf");
            }
            else if (ordersDataGridView.SelectedRows.Count > 1)
            {
                ErrorLabel.Text = "Оберіть лише одну поїздку";
            }
            else
            {
                ErrorLabel.Text = "Оберіть поїздку для отримання звіту";
            }
        }

        private void OrdersViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void setReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 1)
            {
                ErrorLabel.Text = "";
                DataGridViewRow selectedRow = ordersDataGridView.SelectedRows[0];


                ReviewForm mainForm = new ReviewForm(passenger,
                    (int)ordersTableAdapter.GetOrderIdQuery(Convert.ToDateTime(selectedRow.Cells[2].Value),
                    Convert.ToInt32(selectedRow.Cells[7].Value)));
                mainForm.Show();
                this.Hide();
            }
            else if (ordersDataGridView.SelectedRows.Count > 1)
            {
                ErrorLabel.Text = "Оберіть лише одну поїздку";
            }
            else
            {
                ErrorLabel.Text = "Оберіть поїздку для залишення відгуку";
            }
        }
    }
}
