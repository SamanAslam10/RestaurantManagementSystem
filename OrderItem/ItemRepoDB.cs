using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.OrderItem
{
    internal class ItemRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=RMS;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public bool Create(ItemModel item)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO OrderItems (OrderId, FoodId, Quantity) " +
                               "VALUES (@OrderId, @FoodId, @Quantity)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@OrderId", item.OrderId);
                cmd.Parameters.AddWithValue("@FoodId", item.FoodId);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<ItemModel> GetAll()
        {
            List<ItemModel> items = new List<ItemModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT OrderId, FoodId, Quantity FROM OrderItems";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new ItemModel(
                        Convert.ToInt32(reader["OrderId"]),
                        Convert.ToInt32(reader["FoodId"]),
                        Convert.ToSingle(reader["Quantity"])
                    ));
                }
            }
            return items;
        }

        public bool Delete(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM OrderItems WHERE OrderId=@OrderId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
