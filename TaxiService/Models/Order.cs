using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string AdressFrom { get; set; }
        public string AdressTo { get; set; }
        public DateTime? CreationDatetime { get; set; }
        public float Price { get; set; }
        public string OrderState { get; set; }
        public float? LuggageWeight { get; set; }
        public DateTime? PreferredDatetime { get; set; }
        public int? PassengerId { get; set; }
        public int? DriverId { get; set; }

        public Order(int orderId, string adressFrom, string adressTo, DateTime creationDatetime, float price, 
            string orderState, float? luggageWeight, DateTime preferredDatetime, 
            int? passengerId, int? driverId)
        {
            OrderId = orderId;
            AdressFrom = adressFrom;
            AdressTo = adressTo;
            CreationDatetime = creationDatetime;
            Price = price;
            OrderState = orderState;
            LuggageWeight = luggageWeight;
            PreferredDatetime = preferredDatetime;
            PassengerId = passengerId;
            DriverId = driverId;
        }

        public Order(string adressFrom, string adressTo, float price,
            string orderState, int? passengerId)
        {
            AdressFrom = adressFrom;
            AdressTo = adressTo;
            CreationDatetime = DateTime.Now;
            Price = price;
            OrderState = orderState;
            PreferredDatetime = DateTime.Now;
            PassengerId = passengerId;
        }

        public override string ToString()
        {
            return $"Адреса відправлення: {AdressFrom}\n" +
                   $"Адреса призначення: {AdressTo}\n" +
                   $"Дата створення: {CreationDatetime}\n" +
                   $"Ціна: {Price} грн\n" +
                   $"Стан замовлення: {OrderState}\n" +
                   $"Вага багажу: {(LuggageWeight == null ? 0 : LuggageWeight)} кг\n" +
                   $"Бажана дата та час: {PreferredDatetime}\n";
        }

        public static Order GetOrder(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Orders WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
               
                            Order order = new Order(
                                (int)reader["Orders_id"], (string)reader["Adress_from"],
                                (string)reader["Adress_to"], (reader["Creation_datetime"] != DBNull.Value) ? (DateTime)reader["Creation_datetime"] : DateTime.Now,
                                Convert.ToSingle(reader["Price"]), (string)reader["Order_state"],
                                (reader["Luggage_weight"] != DBNull.Value) ? Convert.ToSingle(reader["Luggage_weight"]) : (float?)null,
                                (reader["Preferred_datetime"] != DBNull.Value) ? (DateTime)reader["Preferred_datetime"] : DateTime.Now,
                                (reader["Passenger_id"] != DBNull.Value) ? (int?)reader["Passenger_id"] : (int?)null,
                                (reader["Driver_id"] != DBNull.Value) ? (int?)reader["Driver_id"] : (int?)null);
                            return order;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}
