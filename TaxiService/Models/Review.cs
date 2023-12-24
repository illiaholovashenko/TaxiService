using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TaxiService.Constants;

namespace TaxiService.Models
{
    public class Review
    {
        public float Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int? OrderId { get; set; }



        public Review(float rating, string comment, int? orderId) 
        {
            Rating = rating;
            Comment = comment;
            OrderId = orderId;
        }

        public Review(float rating, string comment, DateTime creationDateTime, int? orderId)
        {
            Rating = rating;
            Comment = comment;
            CreationDateTime = creationDateTime;
            OrderId = orderId;
        }

        public static Review GetReview(string atribute, string value)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string query = $"SELECT * FROM Review WHERE {atribute} = '{value}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new Review(
                                Convert.ToSingle(reader["Rating"]),
                                (reader["Comment"] != DBNull.Value) ? (string)reader["Comment"] : "",
                                (reader["Creation_datetime"] != DBNull.Value) ? (DateTime)reader["Creation_datetime"] : DateTime.Now,
                                (reader["Order_id"] != DBNull.Value) ? (int?)reader["Order_id"] : null);
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
