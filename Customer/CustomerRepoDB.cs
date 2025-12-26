using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace RMS.Customer
{
    internal class CustomerRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=RMS;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public bool Create(CustomerModel customer)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO Customer (CustomerId,Name,Contact,CNIC,Email)" +
                                " VALUES (@CustomerId,@Name, @Contact, @CNIC, @Email)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Contact", customer.contact);
                cmd.Parameters.AddWithValue("@CNIC", customer.CNIC);
                cmd.Parameters.AddWithValue("@Email", customer.email);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> customersList = new List<CustomerModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT CustomerId,Name,Contact,CNIC,Email FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["CustomerId"]);
                    string name = Convert.ToString(reader["Name"]);
                    string Contact = Convert.ToString(reader["Contact"]);
                    string CNIC = Convert.ToString(reader["CNIC"]);
                    string Email = Convert.ToString(reader["Email"]);

                    CustomerModel customer = new CustomerModel(id, name, Contact, CNIC, Email);
                    customersList.Add(customer);
                }
                conn.Close();
            }
            return customersList;
        }
        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE CustomerId=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Update(CustomerModel customer)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE Customer SET Name=@Name,Contact=@Contact,CNIC=@CNIC,Email=@Email" +
                                " WHERE CustomerId=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", customer.Id);
                cmd.Parameters.AddWithValue("@Name", customer.name);
                cmd.Parameters.AddWithValue("@Contact", customer.contact);
                cmd.Parameters.AddWithValue("@CNIC", customer.CNIC);
                cmd.Parameters.AddWithValue("@Email", customer.email);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}