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
using TaxiService.Models;

namespace TaxiService.Forms
{
    public partial class StatisticForm : Form
    {
        Passenger passenger;
        public StatisticForm(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void StatisticForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(passenger);
            mainForm.Show();
            this.Hide();
        }

        private void driverStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dateRangeForm = new dateSelectionForm())
            {
                if (dateRangeForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime fromDate = dateRangeForm.SelectedFromDate;
                    DateTime toDate = dateRangeForm.SelectedToDate;
                    if (fromDate < toDate)
                    {
                        errorLabel.Text = "";
                        string query = "SELECT" +
                            $" CONCAT(Driver.First_name, ' ', Driver.Last_name, ' ', Driver.Middle_name, N' " +
                            $"з {fromDate.ToString("yyyy-MM-dd")} по {toDate.ToString("yyyy-MM-dd")} виконав(ла) ', " +
                            $"COUNT(Orders.Orders_id), N' замовлення.') AS DriversInformation" +
                            " FROM Driver" +
                            " LEFT JOIN Orders ON Driver.Driver_id = Orders.Driver_id" +
                            " WHERE Orders.Order_state = N'Виконано'" +
                            $" AND Orders.Creation_datetime BETWEEN '{fromDate.ToString("yyyy-MM-dd")}' AND '{toDate.ToString("yyyy-MM-dd")}'" +
                            " GROUP BY Driver.First_name, Driver.Last_name, Driver.Middle_name;";
                        SetDBView(statisticDataGridView, query);
                    }
                    else
                    {
                        errorLabel.Text = "Дата \"Від\" має бути раніше ніж \"До\"";
                    }
                }
            }
        }

        private void carStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT Model, Category_name, OrderCount " +
                "FROM ( " +
                "SELECT c.Model, cc.Category_name, COUNT(o.Orders_id) AS OrderCount, " +
                "MAX(COUNT(o.Orders_id)) OVER (PARTITION BY cc.Category_name) AS MaxOrderCount " +
                "FROM Car c " +
                "JOIN Car_category cc ON c.Car_category_id = cc.Car_category_id " +
                "LEFT JOIN Driver d ON c.Driver_id = d.Driver_id " +
                "LEFT JOIN Orders o ON d.Driver_id = o.Driver_id " +
                "GROUP BY c.Model, cc.Category_name) AS RankedCars " +
                "WHERE OrderCount = MaxOrderCount;";
            SetDBView(statisticDataGridView, query);
        }

        private void orderStatisticToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string query = "SELECT " +
                "p.Passenger_id, CONCAT(p.First_name, ' ', p.Last_name) AS PassengerName," +
                " AVG(o.Price) AS AvgOrderPrice," +
                " COUNT(o.Orders_id) AS OrderCount FROM Passenger p" +
                " LEFT JOIN Orders o ON p.Passenger_id = o.Passenger_id " +
                "GROUP BY p.Passenger_id, CONCAT(p.First_name, ' ', p.Last_name);";
            SetDBView(statisticDataGridView, query);
        }

        private void reviewStatisticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string query = "SELECT " +
                "CONCAT(d.First_name, ' ', d.Last_name) AS Driver_name," +
                " COUNT(o.Orders_id) AS Order_count," +
                " COUNT(r.Review_id) AS Review_count," +
                " CASE WHEN COUNT(o.Orders_id) > 0" +
                " THEN (COUNT(r.Review_id)* 100.0) / COUNT(o.Orders_id)" +
                " ELSE 0" +
                " END AS Review_probability" +
                " FROM Driver d" +
                " LEFT JOIN Orders o ON d.Driver_id = o.Driver_id" +
                " LEFT JOIN Review r ON o.Orders_id = r.Order_id" +
                " GROUP BY" +
                " CONCAT(d.First_name, ' ', d.Last_name);";
            SetDBView(statisticDataGridView, query);
        }
    }
}
