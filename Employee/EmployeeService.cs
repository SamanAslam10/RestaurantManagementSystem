using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace RMS.Employee
{
    internal class EmployeeService
    {
        private EmployeeRepoDB repoDB = new EmployeeRepoDB();

        public void AddEMployee(EmployeeModel employee)
        {
            repoDB.Create(employee);
        }
        public void UpdateEmployee(EmployeeModel employee)
        {
            repoDB.Update(employee);
        }
        public void DeleteEMployee(int id)
        {
            repoDB.Delete(id);
        }
        public List<EmployeeModel> GetAllData()
        {
            return repoDB.GetAll();
        }
    }
}