using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class Car
    {
        public string CarNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int ProductionYear { get; set; }
        public int? DriverId { get; set; }
        public int? CarCategoryId { get; set; }
        public CarCategory CarCategory { get; set; }

        public Car(string carNumber, string model, string color, int productionYear, int? driverId, int? carCategoryId)
        {
            CarNumber = carNumber;
            Model = model;
            Color = color;
            ProductionYear = productionYear;
            DriverId = driverId;
            CarCategoryId = carCategoryId;
            CarCategory = CarCategory.GetCarCategory("Car_category_id", carCategoryId.ToString());
        }

        public override string ToString()
        {
            return $"Номер авто: {CarNumber}\n" +
                $"Модель: {Model}\n" +
                $"Колір: {Color}\n" +
                $"Рік випуску: {ProductionYear}\n\n" +
                $"Інформація про категорію авто:\n{CarCategory.ToString()}";
        }

        public static Car GetCar(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Car WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new Car(
                                (string)reader["Car_number"],
                                (string)reader["Model"],
                                (string)reader["Color"], (int)reader["Production_year"],
                                (reader["Driver_id"] != DBNull.Value) ? Convert.ToInt32(reader["Driver_id"]) : (int?)null,
                                (reader["Car_category_id"] != DBNull.Value) ? Convert.ToInt32(reader["Car_category_id"]) : (int?)null);
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
