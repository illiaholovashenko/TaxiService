using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class CarCategory
    {
        public int CarCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int MaxPassengersNumber { get; set; }
        public float KilometerPrice { get; set; }

        public CarCategory(int carCategoryId, string categoryName, int maxPassengersNumber, float kilometerPrice)
        {
            CarCategoryId = carCategoryId;
            CategoryName = categoryName;
            MaxPassengersNumber = maxPassengersNumber;
            KilometerPrice = kilometerPrice;
        }

        public override string ToString()
        {
            return $"Назва категорії: {CategoryName}\n" +
                $"Масимальна кількість пасажирів: {MaxPassengersNumber}\n" +
                $"Ціна за кілометр: {KilometerPrice} грн";
        }

        public static CarCategory GetCarCategory(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Car_category WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
  
                            return new CarCategory(
                                (int)reader["Car_category_id"],
                                (string)reader["Category_name"],
                                (int)reader["Max_passengers_number"], Convert.ToSingle(reader["Kilometer_price"]));
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
