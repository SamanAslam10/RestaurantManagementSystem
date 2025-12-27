using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Order
{
    internal class OrderService
    {
        private OrderRepoDB repoDB = new OrderRepoDB();

        public void AddOrder(OrderModel order)
        {
            repoDB.Create(order);
        }

        public void UpdateOrder(OrderModel order)
        {
            repoDB.Update(order);
        }

        public void DeleteOrder(int id)
        {
            repoDB.Delete(id);
        }

        public List<OrderModel> GetAllOrders()
        {
            return repoDB.GetAll();
        }
    }
}
