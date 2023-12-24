using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static TaxiService.Constants;
using TaxiService.Models;
using System.Windows.Forms;
using System.Data;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Net.Mail;
using System.Net;
using iText.Layout.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Font;
using static GMap.NET.Entity.OpenStreetMapGeocodeEntity;
using System.Threading;
using TextBox = System.Windows.Forms.TextBox;
using System.Text.RegularExpressions;

namespace TaxiService
{
    internal static class Utilities
    {
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public static void RemoveMarkerByCoordinates(GMapControl gmapControl, PointLatLng? pointLatLng)
        {
            if (pointLatLng.HasValue)
            {
                foreach (GMapOverlay overlay in gmapControl.Overlays)
                {
                    // Знайти маркер за координатами
                    GMap.NET.WindowsForms.GMapMarker markerToRemove = overlay.Markers.
                        FirstOrDefault(marker => marker.Position.Lat == pointLatLng.Value.Lat 
                        && marker.Position.Lng == pointLatLng.Value.Lng);

                    // Видалити маркер з оверлею
                    if (markerToRemove != null)
                    {
                        overlay.Markers.Remove(markerToRemove);
                        return;
                    }
                }
            }
        }

        public static void MakeMarkerByCoordinates(GMapControl gmapControl, PointLatLng? pointLatLng, GMarkerGoogleType gMarkerGoogleType)
        {
            if (pointLatLng.HasValue)
            {
                GMap.NET.WindowsForms.GMapMarker marker = new GMarkerGoogle(pointLatLng.Value, gMarkerGoogleType);
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(marker);
                gmapControl.Overlays.Add(markersOverlay);
            }
        }

        public static Location GetLatLngByAddress(String adress)
        {
            // https://us1.locationiq.com/v1/search.php
            var client = new RestSharp.RestClient("https://us1.locationiq.com");
            var request = new RestSharp.RestRequest("v1/search.php", RestSharp.Method.Get);
            request.AddParameter("key", LOCATEIQ_KEY);
            request.AddParameter("q", adress);
            request.AddParameter("format", "json");

            var result = client.Execute(request);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<Location> content = JsonConvert.DeserializeObject<List<Location>>(result.Content);
                return content[0];
            }
            return null;
        }

        public static double GetDistanceByLatLng(PointLatLng? fromPoint, PointLatLng? toPoint)
        {
            // https://us1.locationiq.com/v1/directions/driving/-0.12070277,51.514156;-0.12360937,51.507996?key=pk.fa7b559592cbe77eb4c41242a9457cc6
            var client = new RestSharp.RestClient("https://us1.locationiq.com");
            var request = new RestSharp.RestRequest($"v1/directions/driving/{fromPoint.Value.Lng.ToString(System.Globalization.CultureInfo.InvariantCulture)},{fromPoint.Value.Lat.ToString(System.Globalization.CultureInfo.InvariantCulture)};{toPoint.Value.Lng.ToString(System.Globalization.CultureInfo.InvariantCulture)},{toPoint.Value.Lat.ToString(System.Globalization.CultureInfo.InvariantCulture)}", RestSharp.Method.Get);
            request.AddParameter("key", LOCATEIQ_KEY);

            var result = client.Execute(request);

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = JsonConvert.DeserializeObject<LocationIQResponse>(result.Content);
                if (content != null && content.Routes != null && content.Routes.Count > 0)
                {
                    double distance = content.Routes[0].Legs[0].Distance;
                    return distance;
                }
            }
            return 0;
        }

        public static void SetDBView(DataGridView dataGridView, string query)
        {
            dataGridView.Columns.Clear();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                    dataGridView.AutoGenerateColumns = true;
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        public static float GetKilometerPriceByDriverId(int driverId)
        {
            float kilometerPrice = 0.0f;

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = @"
                    SELECT cc.Kilometer_price
                    FROM Car_category cc
                    JOIN Car c ON cc.Car_category_id = c.Car_category_id
                    JOIN Driver d ON c.Driver_id = d.Driver_id
                    WHERE d.Driver_id = @DriverId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverId", driverId);

                    object result = command.ExecuteScalar();

                    if (result != null && float.TryParse(result.ToString(), out kilometerPrice))
                    {
                        return kilometerPrice;
                    }
                }
            }

            return kilometerPrice;
        }

        public static byte[] CreateOrderPdfReport(string orderDataFromGrid)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var writer = new PdfWriter(memoryStream))
                {
                    PdfFont font = PdfFontFactory.CreateFont(@"D:\\Илья\\Курсове проектування\\PTSans-Regular.ttf", PdfEncodings.IDENTITY_H);
                    DocumentProperties documentProperties = new DocumentProperties();

                    using (var pdf = new PdfDocument(writer))
                    {

                        var document = new Document(pdf);

                        string[] orderValues = orderDataFromGrid.Split(';');

                        document.Add(new Paragraph($"Звіт про замовлення #{orderValues[0]}")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetFontSize(16)
                            .SetBold()
                            .SetFont(font));

     
                        document.Add(new Paragraph($"Деталі замовлення")
                            .SetFontSize(16)
                            .SetBold()
                            .SetFont(font));

                        document.Add(new Paragraph($"{orderValues[1]}")
                            .SetFontSize(12)
                            .SetFont(font));

                        document.Add(new Paragraph($"Інформація про пасажира")
                            .SetFontSize(16)
                            .SetBold()
                            .SetFont(font));

                        document.Add(new Paragraph($"{orderValues[2]}")
                            .SetFontSize(12)
                            .SetFont(font));

                        document.Add(new Paragraph($"Інформація про водія")
                            .SetFontSize(16)
                            .SetBold()
                            .SetFont(font));

                        document.Add(new Paragraph($"{orderValues[3]}")
                            .SetFontSize(12)
                            .SetFont(font));

                        document.Add(new Paragraph($"Звіт сформовано: {DateTime.Now}")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                            .SetFontSize(9)
                            .SetFont(font));

                        document.Add(new Paragraph($"TaxiService")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                            .SetFontSize(10)
                            .SetFont(font));

                        document.Close();
                    }
                }
                return memoryStream.ToArray();
            }
        }

        public static byte[] CreateDriverPdfReport(string driverDataFromGrid)
        {
            using (var memoryStream = new MemoryStream())
            {

                using (var writer = new PdfWriter(memoryStream))
                {
                    PdfFont font = PdfFontFactory.CreateFont(@"D:\\Илья\\Курсове проектування\\PTSans-Regular.ttf", PdfEncodings.IDENTITY_H);
                    DocumentProperties documentProperties = new DocumentProperties();
       
                    using (var pdf = new PdfDocument(writer))
                    {
     
                        var document = new Document(pdf);

                        string[] driverValues = driverDataFromGrid.Split(';');
   
                        document.Add(new Paragraph($"Звіт про водія #{driverValues[0]}")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetFontSize(16)
                            .SetBold()
                            .SetFont(font));

                        document.Add(new Paragraph($"{driverValues[1]}")
                            .SetFontSize(12)
                            .SetFont(font));


                        document.Add(new Paragraph($"Інформація про автомобіль:\n" + 
                                                    $"{driverValues[2]}")
                            .SetFontSize(12)
                            .SetFont(font));

                        document.Add(new Paragraph($"Звіт сформовано: {DateTime.Now}")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                            .SetFontSize(9)
                            .SetFont(font));

                        document.Add(new Paragraph($"TaxiService")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                            .SetFontSize(10)
                            .SetFont(font));

                        document.Close();
                    }
                }
                return memoryStream.ToArray();
            }
        }

        public static void SendEmailWithAttachment(string to, string subject, string body, byte[] attachmentBytes, string attachmentFileName)
        {
            try
            {
                // Параметри SMTP-сервера
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = MY_GOOGLE_MAIL;
                string smtpPassword = PASSWORD;

                // Адреса та порт SMTP-сервера
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                    EnableSsl = true,
                };

                // Адреса електронної пошти відправника
                MailAddress from = new MailAddress(smtpUsername, APP_NAME);

                // Адреса електронної пошти отримувача
                MailAddress toAddress = new MailAddress(to);

                // Створити новий лист
                using (MailMessage message = new MailMessage(from, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    // Додати прикріплений файл
                    Attachment attachment = new Attachment(new MemoryStream(attachmentBytes), attachmentFileName, "application/pdf");
                    message.Attachments.Add(attachment);

                    // Відправити лист
                    smtpClient.Send(message);
                }

                Console.WriteLine("Електронний лист надіслано успішно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка відправки електронного листа: {ex.Message}");
            }
        }

        public static bool IsWeatherBad(PointLatLng? geoposition)
        {
            if (geoposition.HasValue)
            {
                //https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid={API key}
                var client = new RestSharp.RestClient("https://api.openweathermap.org");
                var request = new RestSharp.RestRequest("data/2.5/weather", RestSharp.Method.Get);
                request.AddParameter("appid", OPEN_WEATHER_KEY);
                request.AddParameter("lat", geoposition.Value.Lat);
                request.AddParameter("lon", geoposition.Value.Lng);
                request.AddParameter("format", "json");

                var result = client.Execute(request);

                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic data = JsonConvert.DeserializeObject(result.Content);
                    string mainWeather = data.weather[0].main;
                    return mainWeather == "Rain" || mainWeather == "Snow" || mainWeather == "Thunderstorm";
                        
                }
              
            }
            return false;
        }

        public static void floatInput(object sender, KeyPressEventArgs e)
        {
            char decimalSeparator = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparator))
            {
                e.Handled = true;
            }

            // Дозволяє використовувати тільки один десятковий роздільник
            if ((e.KeyChar == decimalSeparator) && ((sender as TextBox).Text.IndexOf(decimalSeparator) > -1))
            {
                e.Handled = true;
            }
        }

        public static void intInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
