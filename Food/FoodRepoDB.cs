using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Food
{
    internal class FoodRepoDB
    {
        private readonly string DbConnection =
            "Server=localhost\\MSSQLSERVER01;Database=RMS;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public bool Create(FoodModel food)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO Food (FoodId, Name, Price, Type) VALUES (@FoodId, @Name, @Price, @Type)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FoodId", food.FoodId);
                cmd.Parameters.AddWithValue("@Name", food.Name);
                cmd.Parameters.AddWithValue("@Price", food.Price);
                cmd.Parameters.AddWithValue("@Type", food.Type);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<FoodModel> GetAll()
        {
            List<FoodModel> foodList = new List<FoodModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT FoodId, Name, Price, Type FROM Food";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FoodModel food = new FoodModel(
                        Convert.ToInt32(reader["FoodId"]),
                        reader["Name"].ToString(),
                        Convert.ToSingle(reader["Price"]),
                        reader["Type"].ToString()
                    );

                    foodList.Add(food);
                }
            }
            return foodList;
        }

        public bool Update(FoodModel food)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE Food SET Name=@Name, Price=@Price, Type=@Type WHERE FoodId=@FoodId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FoodId", food.FoodId);
                cmd.Parameters.AddWithValue("@Name", food.Name);
                cmd.Parameters.AddWithValue("@Price", food.Price);
                cmd.Parameters.AddWithValue("@Type", food.Type);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM Food WHERE FoodId=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
