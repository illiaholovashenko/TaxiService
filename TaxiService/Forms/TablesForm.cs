using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.TaxiDataSetTableAdapters;
using TaxiService.Models;
using static TaxiService.Models.Car;
using static TaxiService.Models.CarCategory;
using static TaxiService.Models.Driver;
using static TaxiService.Models.Order;
using static TaxiService.Models.Passenger;


namespace TaxiService.Forms
{
    public partial class TablesForm : Form
    {
        Passenger Passenger;
        private bool edit;
        public TablesForm(Passenger Passenger)
        {
            InitializeComponent();
            this.Passenger = Passenger;
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Car_category' table. You can move, or remove it, as needed.
            this.car_categoryTableAdapter.Fill(this.taxiDataSet.Car_category);
            // TODO: This line of code loads data into the 'taxiDataSet.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter.Fill(this.taxiDataSet.Review);
            // TODO: This line of code loads data into the 'taxiDataSet.Passenger' table. You can move, or remove it, as needed.
            this.passengerTableAdapter.Fill(this.taxiDataSet.Passenger);
            // TODO: This line of code loads data into the 'taxiDataSet.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.taxiDataSet.Car);
            // TODO: This line of code loads data into the 'taxiDataSet.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.taxiDataSet.Driver);
            // TODO: This line of code loads data into the 'taxiDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.taxiDataSet.Orders);

            dataGridView1.AutoGenerateColumns = true;
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = driverBindingSource;
            dataGridView1.DataSource = driverBindingSource;
            tableNameLabel.Text = "Водії";
        }

        private void passengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = passengerBindingSource;
            dataGridView1.DataSource = passengerBindingSource;
            tableNameLabel.Text = "Пасажири";
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = ordersBindingSource;
            dataGridView1.DataSource = ordersBindingSource;
            tableNameLabel.Text = "Замовлення";
        }

        private void carCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = carcategoryBindingSource;
            dataGridView1.DataSource = carcategoryBindingSource;
            tableNameLabel.Text = "Категорія авто";
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = carBindingSource;
            dataGridView1.DataSource = carBindingSource;
            tableNameLabel.Text = "Авто";
        }

        private void TablesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ordersTableAdapter.Update(taxiDataSet);
            driverTableAdapter.Update(taxiDataSet);
            passengerTableAdapter.Update(taxiDataSet);
            carTableAdapter.Update(taxiDataSet);
            car_categoryTableAdapter.Update(taxiDataSet);
            Application.Exit();
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(Passenger);
            mainForm.Show();
            this.Hide();
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var QForm = new QueryEditForm();
            QForm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.Update(taxiDataSet);
            passengerTableAdapter.Update(taxiDataSet);
            driverTableAdapter.Update(taxiDataSet);
            carTableAdapter.Update(taxiDataSet);
            car_categoryTableAdapter.Update(taxiDataSet);

            switch (tableNameLabel.Text)
            {

                case "Авто":
                    var carForm = new CarForm();
                    carForm.ShowDialog();
                    carTableAdapter.Fill(taxiDataSet.Car);
                    taxiDataSet.AcceptChanges();
                    break;
                case "Категорія авто":
                    var carCategoryForm = new CarCategoryForm();
                    carCategoryForm.ShowDialog();
                    car_categoryTableAdapter.Fill(taxiDataSet.Car_category);
                    taxiDataSet.AcceptChanges();
                    break;
                case "Пасажири":
                    var passengerForm = new UserAccountForm(false);
                    passengerForm.ShowDialog();
                    passengerTableAdapter.Fill(taxiDataSet.Passenger);
                    taxiDataSet.AcceptChanges();
                    break;
                case "Водії":
                    var driverForm = new DriverForm();
                    driverForm.ShowDialog();
                    driverTableAdapter.Fill(taxiDataSet.Driver);
                    taxiDataSet.AcceptChanges();
                    break;
                case "Замовлення":
                    var orderForm = new OrderForm();
                    orderForm.ShowDialog();
                    ordersTableAdapter.Fill(taxiDataSet.Orders);
                    taxiDataSet.AcceptChanges();
                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ErrorLabel.Text = "";
                ordersTableAdapter.Update(taxiDataSet);
                passengerTableAdapter.Update(taxiDataSet);
                driverTableAdapter.Update(taxiDataSet);
                carTableAdapter.Update(taxiDataSet);
                car_categoryTableAdapter.Update(taxiDataSet);
                edit = true;

                switch (tableNameLabel.Text)
                {

                    case "Авто":
                        var carForm = new CarForm(GetCar("Car_number", dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString()));
                        carForm.ShowDialog();
                        carTableAdapter.Fill(taxiDataSet.Car);
                        taxiDataSet.AcceptChanges();
                        break;
                    case "Категорія авто":
                        var carCategoryForm = new CarCategoryForm(GetCarCategory("Car_category_id", dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString()));
                        carCategoryForm.ShowDialog();
                        car_categoryTableAdapter.Fill(taxiDataSet.Car_category);
                        taxiDataSet.AcceptChanges();
                        break;
                    case "Пасажири":
                        var passengerForm = new UserAccountForm(GetPassenger("Passenger_id", dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString()), true);
                        passengerForm.ShowDialog();
                        passengerTableAdapter.Fill(taxiDataSet.Passenger);
                        taxiDataSet.AcceptChanges();
                        break;
                    case "Водії":
                        var driverForm = new DriverForm(GetDriver("Driver_id", dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString()));
                        driverForm.ShowDialog();
                        driverTableAdapter.Fill(taxiDataSet.Driver);
                        taxiDataSet.AcceptChanges();
                        break;
                    case "Замовлення":
                        var orderForm = new OrderForm(GetOrder("Orders_id", dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString()));
                        orderForm.ShowDialog();
                        ordersTableAdapter.Fill(taxiDataSet.Orders);
                        taxiDataSet.AcceptChanges();
                        break;
                }
            }
            else
            {
                ErrorLabel.Text = "Оберіть один елемент зі списку";
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ErrorLabel.Text = "";
                if (MessageBox.Show("Ви точно бажаєте видалити цей елемент з бази даних?",
                            "Змінення даних", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    switch (tableNameLabel.Text)
                    {

                        case "Авто":
                            carTableAdapter.DeleteQuery(dataGridView1.
                            SelectedRows[0].Cells[0].Value.ToString());
                            carTableAdapter.Fill(taxiDataSet.Car);
                            taxiDataSet.AcceptChanges();
                            break;
                        case "Категорія авто":
                            car_categoryTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.
                            SelectedRows[0].Cells[0].Value));
                            car_categoryTableAdapter.Fill(taxiDataSet.Car_category);
                            taxiDataSet.AcceptChanges();
                            break;
                        case "Пасажири":
                            passengerTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.
                            SelectedRows[0].Cells[0].Value));
                            passengerTableAdapter.Fill(taxiDataSet.Passenger);
                            taxiDataSet.AcceptChanges();
                            break;
                        case "Водії":
                            driverTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.
                            SelectedRows[0].Cells[0].Value));
                            driverTableAdapter.Fill(taxiDataSet.Driver);
                            taxiDataSet.AcceptChanges();
                            break;
                        case "Замовлення":
                            ordersTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.
                            SelectedRows[0].Cells[0].Value));
                            ordersTableAdapter.Fill(taxiDataSet.Orders);
                            taxiDataSet.AcceptChanges();
                            break;
                    }
                }
            }
            else
            {
                ErrorLabel.Text = "Оберіть один елемент зі списку";
            }
        }
    }
}
