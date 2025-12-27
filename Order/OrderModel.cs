using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Order
{
    internal class OrderModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public float Bill { get; set; }
        public string Paid_Type { get; set; }

        public OrderModel() { }

        public OrderModel(int orderId, int customerId, int employeeId, float bill, string paidType)
        {
            this.OrderId = orderId;
            this.CustomerId = customerId;
            this.EmployeeId = employeeId;
            this.Bill = bill;
            this.Paid_Type = paidType;
        }

    }
}
