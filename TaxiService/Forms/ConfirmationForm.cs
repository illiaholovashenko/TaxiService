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
using static TaxiService.Constants;
using static TaxiService.Utilities;
using static TaxiService.Models.Driver;

namespace TaxiService.Forms
{
    public partial class ConfirmationForm : Form
    {
        Passenger Passenger;
        Order order;

        public ConfirmationForm(Passenger Passenger, Order order)
        {
            InitializeComponent();
            this.Passenger = Passenger;
            this.order = order;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            order.Price = Convert.ToSingle(Math.Round(order.Price / GetKilometerPriceByDriverId(Convert.ToInt32(order.DriverId)), 1));
            DriverSelectionForm driver = new DriverSelectionForm(Passenger, order, GetDriver("Driver_id", order.DriverId.ToString()).PhoneNumber);
            driver.Show();
            this.Hide();
        }

        private void confirmationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            order.OrderState = STATE_DONE;
            order.LuggageWeight = (luggageTextBox.Text.Length > 0) ? Convert.ToSingle(luggageTextBox.Text) : 0f;
            order.Price += (luggageTextBox.Text.Length > 0) ? Convert.ToSingle(luggageTextBox.Text) * 5 : 0; //  кожен кілограм багажу - 5грн
            order.PreferredDatetime = (preferredDateTimePicker.Value > order.PreferredDatetime) ? preferredDateTimePicker.Value : order.PreferredDatetime;

            ordersTableAdapter.InsertQueryDefault(order.AdressFrom, order.AdressTo, order.CreationDatetime,
                order.Price, order.OrderState, (order.LuggageWeight == 0) ? (double?)null : order.LuggageWeight, order.PreferredDatetime, order.PassengerId,
                order.DriverId);
            MainForm main = new MainForm(Passenger);
            main.Show();
            this.Hide();
        }

        private void luggageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(sender, e);
        }

        private void luggageTextBox_TextChanged(object sender, EventArgs e)
        {
            if (luggageTextBox.Text.Length > 0)
            {
                priceLabel.Text = $"Кінцева ціна: {order.Price + (Convert.ToSingle(luggageTextBox.Text) * 5)} грн";
            }
            else
            {
                priceLabel.Text = $"Кінцева ціна: {order.Price} грн";
            }
        }

        private void confirmationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.taxiDataSet.Orders);
            priceLabel.Text = $"Кінцева ціна: {order.Price} грн";
        }
    }
}
