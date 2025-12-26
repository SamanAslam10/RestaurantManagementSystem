using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using v._3._0.Product;

namespace RMS.Employee
{
    internal class EmployeeRepoDB
    {
        private readonly string DbConnection = "Server=localhost\\MSSQLSERVER01;Database=RMS;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
        public bool Create(EmployeeModel employee)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "INSERT INTO [EmployeeData] (EmployeeId,First_Name,Last_Name,CNIC,Phone,Email,Address,HireDate,RoleId,Salary,Status,Role)" +
                               " VALUES (@EmployeeId,@First_Name,@Last_Name,@CNIC,@Phone,@Email,@Address,@HireDate,@RoleId,@Salary,@Status,@Role)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("@First_Name", employee.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", employee.Last_Name);
                cmd.Parameters.AddWithValue("@CNIC", employee.CNIC);
                cmd.Parameters.AddWithValue("@Phone", employee.phone);
                cmd.Parameters.AddWithValue("@Email", employee.email);
                cmd.Parameters.AddWithValue("@Address", employee.address);
                cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Parameters.AddWithValue("@Status", employee.status);

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
        public List<EmployeeModel> GetAll()
        {
            List<EmployeeModel> employeelist = new List<EmployeeModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "SELECT EmployeeId,First_Name,Last_Name,CNIC,Phone,Email,Address,HireDate,RoleId,Salary,Status,Role FROM [EmployeeData]";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["EmployeeID"]);
                    string fname = Convert.ToString(reader["First_Name"]);
                    string lname = Convert.ToString(reader["Last_Name"]);
                    string cnic = Convert.ToString(reader["CNIC"]);
                    string phone = Convert.ToString(reader["Phone"]);
                    string email = Convert.ToString(reader["Email"]);
                    string address = Convert.ToString(reader["Address"]);
                    string hireDate = Convert.ToString(reader["HireDate"]);
                    string Role = Convert.ToString(reader["Role"]);
                    int roleId = Convert.ToInt32(reader["RoleId"]);
                    string status = Convert.ToString(reader["Status"]);
                    float salary = Convert.ToSingle(reader["Salary"]);


                    EmployeeModel product = new EmployeeModel(id , fname , lname , phone , cnic , email , address , hireDate , roleId , Role , status , salary);
                    employeelist.Add(product);
                }
                conn.Close();
            }
            return employeelist;
        }
        public bool Update(EmployeeModel employee)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "UPDATE [EmployeeData] SET First_Name=@First_Name,Last_Name=@Last_Name," +
                    "CNIC=@CNIC,Phone=@Phone,Email=@Email,Address=@Address,HireDate=@HireDate,RoleId=@RoleId,Salary=@Salary,Status=@Status,Role=@Role " +
                                " WHERE EmployeeId=@EmployeeId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", employee.Id);
                cmd.Parameters.AddWithValue("@First_Name", employee.First_Name);
                cmd.Parameters.AddWithValue("@Last_Name", employee.Last_Name);
                cmd.Parameters.AddWithValue("@CNIC", employee.CNIC);
                cmd.Parameters.AddWithValue("@Phone", employee.phone);
                cmd.Parameters.AddWithValue("@Email", employee.email);
                cmd.Parameters.AddWithValue("@Address", employee.address);
                cmd.Parameters.AddWithValue("@HireDate", employee.HireDate);
                cmd.Parameters.AddWithValue("@RoleId", employee.RoleId);
                cmd.Parameters.AddWithValue("@Role", employee.Role);
                cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                cmd.Parameters.AddWithValue("@Status", employee.status);

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
        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                conn.Open();
                string query = "DELETE FROM [EmployeeData] WHERE EmployeeId=@ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

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