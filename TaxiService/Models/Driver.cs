using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public float? Rating { get; set; }
        public DateTime DrivingExperience { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Driver(int driverId, string firstName, string lastName, string middleName, string phoneNumber, string city,
                          float? rating, DateTime drivingExperience, DateTime registrationDate, string email, DateTime birthDate)
        {
            DriverId = driverId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phoneNumber;
            City = city;
            Rating = rating;
            DrivingExperience = drivingExperience;
            RegistrationDate = registrationDate;
            Email = email;
            BirthDate = birthDate;
        }


        public override string ToString()
        {
            return $"Повне ім'я: {FirstName} {LastName} {MiddleName}\n" +
                $"Номер телефону: {PhoneNumber}\n" +
                $"Рейтинг: {(Rating == null ? 0 : Rating)}\n" +
                $"Досвід водіння: {(int)((DateTime.Now - DrivingExperience).TotalDays / 365.25)} років\n" +
                $"Email: {(Email == null ? "Не вказаний" : Email)}\n" +
                $"Вік: {(int)((DateTime.Now - BirthDate).TotalDays / 365.25)} років";
        }

        public static Driver GetDriver(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Driver WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new Driver(
                                (int)reader["Driver_id"],
                                (string)reader["First_name"],
                                (string)reader["Last_name"], (string)reader["Middle_name"],
                                (string)reader["Phone_number"], (string)reader["City"],
                                (reader["Rating"] != DBNull.Value) ? Convert.ToSingle(reader["Rating"]) : (float?)null,
                                (DateTime)reader["Driving_expirience"],
                                (DateTime)reader["Registration_date"],
                                (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : null,
                                (DateTime)reader["Birth_date"]);
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
