using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        private DateTime? _birthDate;
        public DateTime? BirthDate 
        { 
            get { return _birthDate; }
            set
            {
                if (value == DateTime.MinValue)
                    _birthDate = null;
                else
                    _birthDate = value;
            }
        }
        public string Gender { get; set; }
        public string Email { get; set; }

        public Passenger(int passengerId, string firstName, 
            string lastName, string phoneNumber, DateTime? birthDate, 
            string gender, string email)
        {
            PassengerId = passengerId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
        }

        public override string ToString() 
        {
            return $"Пасажир: {this.FirstName} {this.LastName}\n " +
                $"Електронна пошта: {this.Email}";
        }

        public static Passenger GetPassenger(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Passenger WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                   
                            return new Passenger(
                                (int)reader["Passenger_id"],
                                (reader["First_name"] != DBNull.Value) ? (string)reader["First_name"] : null,
                                (reader["Last_name"] != DBNull.Value) ? (string)reader["Last_name"] : null,
                                (reader["Phone_number"] != DBNull.Value) ? (string)reader["Phone_number"] : null,
                                (reader["Birth_date"] != DBNull.Value) ? (DateTime)reader["Birth_date"] : DateTime.MinValue,
                                (reader["Gender"] != DBNull.Value) ? (string)reader["Gender"] : null,
                                (string)reader["Email"]);
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
