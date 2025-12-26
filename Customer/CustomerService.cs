using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v._3._0.Customer
{
    internal class CustomerService
    {
        private CustomerRepoDB repoDB = new CustomerRepoDB();
        public void AddCustomer(CustomerModel customer)
        {
            repoDB.Create(customer);
        }
        public void UpdateCustomer(CustomerModel customer)
        {
            repoDB.Update(customer);
        }
        public void DeleteCustomer(int id )
        {
            repoDB.Delete(id);
        }
        public List<CustomerModel> GetAllData()
        {
            return repoDB.GetAll();
        }
    }
}