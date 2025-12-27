using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Order
{
    internal class OrderRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=RMS;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        public bool Create(OrderModel order)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO Orders (OrderId, CustomerId, EmployeeId, Bill, Paid_Type) " +
                               "VALUES (@OrderId, @CustomerId, @EmployeeId, @Bill, @Paid_Type)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@OrderId", order.OrderId);
                cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@EmployeeId", order.EmployeeId);
                cmd.Parameters.AddWithValue("@Bill", order.Bill);
                cmd.Parameters.AddWithValue("@Paid_Type", order.Paid_Type);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<OrderModel> GetAll()
        {
            List<OrderModel> orderList = new List<OrderModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT OrderId, CustomerId, EmployeeId, Bill, Paid_Type FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrderModel order = new OrderModel(
                        Convert.ToInt32(reader["OrderId"]),
                        Convert.ToInt32(reader["CustomerId"]),
                        Convert.ToInt32(reader["EmployeeId"]),
                        Convert.ToSingle(reader["Bill"]),
                        reader["Paid_Type"].ToString()
                    );

                    orderList.Add(order);
                }
            }
            return orderList;
        }

        public bool Update(OrderModel order)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE Orders SET CustomerId=@CustomerId, EmployeeId=@EmployeeId, " +
                               "Bill=@Bill, Paid_Type=@Paid_Type WHERE OrderId=@OrderId";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@OrderId", order.OrderId);
                cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                cmd.Parameters.AddWithValue("@EmployeeId", order.EmployeeId);
                cmd.Parameters.AddWithValue("@Bill", order.Bill);
                cmd.Parameters.AddWithValue("@Paid_Type", order.Paid_Type);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM Orders WHERE OrderId=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
