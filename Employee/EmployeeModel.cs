using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RMS.Employee
{
    internal class EmployeeModel
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string phone { get; set; }
        public string CNIC { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string HireDate {  get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string status { get; set; }
        public float Salary { get; set; }

        public EmployeeModel() { }
        public EmployeeModel(int id ,string f_name, string l_name , string phone , string cnic , string email , string address , string hireDate , int roleId , string role , string status , float salary )
        {
            this.Id = id;
            this.First_Name = f_name;
            this.Last_Name = l_name;
            this.phone = phone; 
            this.CNIC = cnic;
            this.email = email;
            this.address = address;
            this.HireDate = hireDate;
            this.RoleId = roleId;
            this.Role = role;
            this.status = status;
            this.Salary = salary;

        } 
    }
}