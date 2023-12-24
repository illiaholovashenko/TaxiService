using iText.StyledXmlParser.Jsoup.Select;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiService.Models;

namespace TaxiService
{
    internal static class Constants
    {
        public const string PASSWORD = "121NuRe22";
        public const string MY_GOOGLE_MAIL = "illia.holovashenko@nure.ua";
        public const string MAIL_SUBJECT = "TaxiService Authorisation";
        public const string MAIL_TEXT = "<h2>Ваш код для входу в TaxiService:</h2>";
        public const string MAIL_ORDER_PDF_SUBJECT = "TaxiService Order Report";
        public const string MAIL_ORDER_PDF_TEXT = "<h2>Ваш звіт про поїздку в TaxiService:</h2>";
        public const string MAIL_DRIVER_PDF_SUBJECT = "TaxiService Driver Report";
        public const string MAIL_DRIVER_PDF_TEXT = "<h2>Ваш звіт про водія TaxiService:</h2>";
        public const string APP_NAME = "TaxiService";
        public const string CONNECTION_STRING = @"Data Source=VOLODYMYR;Initial Catalog=Taxi;Integrated Security=True";
        public const string ADDRESS_PLACEHOLDER = "Харків, проспект Науки, 14";
        public const string STATE_PROCCESSING = "Оброблюється";
        public const string STATE_WAITING = "В очікуванні";
        public const string STATE_PERFORMS = "Виконується";
        public const string STATE_DONE = "Виконано";
        public const string STATE_CANCELED = "Скасовано";
        public const string ERROR_INPUT = "Заповніть усі необхідні поля";
        public const string LOCATEIQ_KEY = "pk.fa7b559592cbe77eb4c41242a9457cc6";
        public const string OPEN_WEATHER_KEY = "c6c939d1e02d3a02b8605ffcee019781";


        public const string DRIVER_DB_INIT = "SELECT " +
            "CONCAT(First_name, ' ', Last_name, ' ', Middle_name) AS Full_name, " +
            "Phone_number, City, Rating, DATEDIFF(YEAR, Driving_expirience, GETDATE()) AS Driving_experience_years, " +
            "DATEDIFF(YEAR, Birth_date, GETDATE()) AS Age, Category_name AS Car_category, COUNT(Orders.Orders_id) AS TotalOrders " +
            "FROM Driver " +
            "JOIN Car ON Driver.Driver_id = Car.Driver_id " +
            "JOIN Car_category ON Car.Car_category_id = Car_category.Car_category_id " +
            "LEFT JOIN Orders ON Driver.Driver_id = Orders.Driver_id ";

        public const string DRIVER_DB_INIT_GROUP_BY = "GROUP BY CONCAT(First_name, ' ', Last_name, ' ', Middle_name), " +
            "Phone_number, City, Rating, DATEDIFF(YEAR, Driving_expirience, GETDATE()), " +
            "DATEDIFF(YEAR, Birth_date, GETDATE()), Category_name";

        public const string ORDERS_DB_INIT = "SELECT Adress_from, Adress_to, Creation_datetime, " +
            "Price, Order_state, Luggage_weight, Preferred_datetime, Passenger_id, Driver_id FROM Orders";
    }
}
