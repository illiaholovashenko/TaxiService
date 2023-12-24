using iText.IO.Util;
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
using static GMap.NET.Entity.OpenStreetMapGeocodeEntity;
using static TaxiService.Utilities;
using static TaxiService.Constants;


namespace TaxiService.Forms
{
    public partial class OrderForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public OrderForm()
        {
            InitializeComponent();
            driverTableAdapter.Fill(taxiDataSet.Driver);
            passengerTableAdapter.Fill(taxiDataSet.Passenger);
            edit = false;
        }

        public OrderForm(Order order)
        {
            InitializeComponent();
            driverTableAdapter.Fill(taxiDataSet.Driver);
            passengerTableAdapter.Fill(taxiDataSet.Passenger);

            edit = true;
            id = order.OrderId;
            adress_fromTextBox.Text = order.AdressFrom;
            adress_toTextBox.Text = order.AdressTo;
            priceTextBox.Text = order.Price.ToString();
            creation_datetimeDateTimePicker.Value = Convert.ToDateTime(order.CreationDatetime);
            switch (order.OrderState.ToLower())
            {
                case "в очікуванні":
                    order_stateComboBox.SelectedIndex = 0;
                    break;
                case "виконується":
                    order_stateComboBox.SelectedIndex = 1;
                    break;
                case "виконано":
                    order_stateComboBox.SelectedIndex = 2;
                    break;
                case "скасовано":
                    order_stateComboBox.SelectedIndex = 3;
                    break;
                default:
                    order_stateComboBox.SelectedIndex = 0;
                    break;
            }
            luggage_weightTextBox.Text = order.LuggageWeight.ToString();
            preferred_datetimeDateTimePicker.Value = Convert.ToDateTime(order.PreferredDatetime);
            passenger_idComboBox.SelectedValue = order.PassengerId ?? 0;
            driver_idComboBox.SelectedValue = order.DriverId ?? 0;

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            int selectedDriver = Convert.ToInt32(driver_idComboBox.SelectedValue);
            int selectedPassenger = Convert.ToInt32(passenger_idComboBox.SelectedValue);

            // TODO: This line of code loads data into the 'taxiDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.taxiDataSet.Driver);
            // TODO: This line of code loads data into the 'taxiDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this.taxiDataSet.Passenger);
            // TODO: This line of code loads data into the 'taxiDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.taxiDataSet.Orders);

            driver_idComboBox.SelectedValue = selectedDriver;
            passenger_idComboBox.SelectedValue = selectedPassenger;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (inputCheck() &&  MessageBox.Show("Ви підтверджуєте оновлення даних?",
                "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
      
                string orderState = "";
                if (order_stateComboBox.SelectedIndex == 0)
                {
                    orderState = "В очікуванні";
                }
                else if (order_stateComboBox.SelectedIndex == 1)
                {
                    orderState = "Виконується";
                }
                else if (order_stateComboBox.SelectedIndex == 2)
                {
                    orderState = "Виконано";
                }
                else if (order_stateComboBox.SelectedIndex == 3)
                {
                    orderState = "Скасовано";
                }

                if (edit)
                {
                    ordersTableAdapter.UpdateQuery(adress_fromTextBox.Text,
                        adress_toTextBox.Text, creation_datetimeDateTimePicker.Value,
                        Convert.ToDouble(priceTextBox.Text), orderState,
                        (luggage_weightTextBox.Text != "") ? Convert.ToDouble(luggage_weightTextBox.Text) : (double?)null,
                        preferred_datetimeDateTimePicker.Value,
                        (passenger_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(passenger_idComboBox.SelectedValue) : (int?)null,
                        (driver_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(driver_idComboBox.SelectedValue) : (int?)null, id);
                }
                else
                {
                    ordersTableAdapter.InsertQueryDefault(adress_fromTextBox.Text,
                        adress_toTextBox.Text, creation_datetimeDateTimePicker.Value,
                        Convert.ToDouble(priceTextBox.Text), orderState,
                        (luggage_weightTextBox.Text != "") ? Convert.ToDouble(luggage_weightTextBox.Text) : (double?)null,
                        preferred_datetimeDateTimePicker.Value,
                        (passenger_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(passenger_idComboBox.SelectedValue) : (int?)null,
                        (driver_idComboBox.SelectedValue != null) ?
                        Convert.ToInt32(driver_idComboBox.SelectedValue) : (int?)null);
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

        private bool inputCheck()
        {
            if (adress_fromTextBox.Text != "" && adress_toTextBox.Text != "" 
                && priceTextBox.Text != "" && order_stateComboBox.Text != "")
            {
                return true;
            }
            return false;
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(sender, e);
        }

        private void luggage_weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            floatInput(sender, e);
        }
    }
}
