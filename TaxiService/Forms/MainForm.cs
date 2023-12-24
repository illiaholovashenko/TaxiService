using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using static TaxiService.Constants;
using static TaxiService.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using TaxiService.TaxiDataSetTableAdapters;
using TaxiService.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using GMap.NET.WindowsPresentation;
using TaxiService.Models;

namespace TaxiService
{
    public partial class MainForm : Form
    {
        Passenger passenger;
        bool badWeather = false;
        PointLatLng? geoposition = null;
        PointLatLng? fromPoint = null;
        PointLatLng? toPoint = null;

        public MainForm(Passenger passenger)
        {
            InitializeComponent();
            this.passenger = passenger;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.taxiDataSet.Orders);

            fromTextBox.Text = ADDRESS_PLACEHOLDER;
            fromTextBox.ForeColor = System.Drawing.SystemColors.GrayText;

            toTextBox.Text = ADDRESS_PLACEHOLDER;
            toTextBox.ForeColor = System.Drawing.SystemColors.GrayText;

            if (passenger.Email != "illia.holovashenko@nure.ua")
            {
                aboutToolStripMenuItem.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MyAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountForm userAccountForm = new UserAccountForm(passenger);
            userAccountForm.Show();
            this.Hide();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            googleMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            googleMap.MinZoom = 2;
            googleMap.MaxZoom = 16;
            googleMap.Zoom = 8;

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.MovementThreshold = 0.1;
            watcher.StatusChanged += async (s, ev) =>
            {
                if (watcher.Status == GeoPositionStatus.Ready)
                {
                    PointLatLng? coordinate = new PointLatLng(watcher.Position.Location.Latitude, 
                        watcher.Position.Location.Longitude);
                    await UpdateMapAsync(coordinate);
                    WeatherNotificationLabel.Text = badWeather ? "Помічено погіршення погодних умов. " +
                    "Можливий підвищений попит на таксі!" : "";
                }
            };
            watcher.Start();

            googleMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            googleMap.CanDragMap = true;
            googleMap.DragButton = MouseButtons.Left;
            googleMap.ShowCenter = false;
            googleMap.ShowTileGridLines = false;
        }

        private void fromTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fromTextBox.Text))
            {
                fromTextBox.Text = ADDRESS_PLACEHOLDER;
                fromTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
                return;
            }

            if (fromPoint == null)
            {
                string fromAdress = fromTextBox.Text;
                Location location = GetLatLngByAddress(fromAdress);
                if (location != null)
                {
                    fromPoint = new PointLatLng(location.Lat, location.Lon);
                    MakeMarkerByCoordinates(googleMap, fromPoint, GMarkerGoogleType.green);
                }
            }
            else
            {
                string fromAdress = fromTextBox.Text;
                Location location = GetLatLngByAddress(fromAdress);
                if (location != null)
                {
                    RemoveMarkerByCoordinates(googleMap, fromPoint);
                    fromPoint = new PointLatLng(location.Lat, location.Lon);
                    MakeMarkerByCoordinates(googleMap, fromPoint, GMarkerGoogleType.green);
                }
            }
        }

        private void fromTextBox_Enter(object sender, EventArgs e)
        {
            if (fromTextBox.Text == ADDRESS_PLACEHOLDER)
            {
                fromTextBox.Text = "";
                fromTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void toTextBox_Enter(object sender, EventArgs e)
        {
            if (toTextBox.Text == ADDRESS_PLACEHOLDER)
            {
                toTextBox.Text = "";
                toTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void toTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toTextBox.Text))
            {
                toTextBox.Text = ADDRESS_PLACEHOLDER;
                toTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
                return;
            }

            if (toPoint == null)
            {
                string toAdress = toTextBox.Text;
                Location location = GetLatLngByAddress(toAdress);
                if (location != null)
                {
                    toPoint = new PointLatLng(location.Lat, location.Lon);
                    MakeMarkerByCoordinates(googleMap, toPoint, GMarkerGoogleType.arrow);
                }
            }
            else
            {
                string toAdress = toTextBox.Text;
                Location location = GetLatLngByAddress(toAdress);
                if (location != null)
                {
                    RemoveMarkerByCoordinates(googleMap, toPoint);
                    toPoint = new PointLatLng(location.Lat, location.Lon);
                    MakeMarkerByCoordinates(googleMap, toPoint, GMarkerGoogleType.arrow);
                }
            }
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            if (fromPoint.HasValue && toPoint.HasValue)
            {
                ErrorLabel.Text = "";
                float orderPrice = Convert.ToSingle(GetDistanceByLatLng(fromPoint, toPoint) / 1000);
                orderPrice += badWeather ? Convert.ToSingle(orderPrice * 0.1) : 0f; 

                Order order = new Order(fromTextBox.Text, toTextBox.Text, orderPrice, STATE_PROCCESSING, passenger.PassengerId);

                DriverSelectionForm driverSelectionForm = new DriverSelectionForm(passenger, order);
                driverSelectionForm.Show();
                this.Hide();
            }
            else
            {
                ErrorLabel.Text = "Заповніть усі поля";
            }
        }

        async Task UpdateMapAsync(PointLatLng? coordinate)
        {
            if (coordinate.HasValue)
            {
                // Встановлення позиції та центрування карти на координатах користувача
                googleMap.Position = new PointLatLng(coordinate.Value.Lat, coordinate.Value.Lng);
                geoposition = new PointLatLng(coordinate.Value.Lat, coordinate.Value.Lng);
                badWeather = IsWeatherBad(geoposition);
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersViewForm orders = new OrdersViewForm(passenger);
            orders.Show();
            this.Hide();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm(passenger);
            statisticForm.Show();
            this.Hide();
        }

        private void таблиціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm(passenger);
            tablesForm.Show();
            this.Hide();
        }
    }
}
