using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.OrderItem
{
    internal class ItemService
    {
        private ItemRepoDB repoDB = new ItemRepoDB();

        public void AddItem(ItemModel item)
        {
            repoDB.Create(item);
        }

        public void DeleteItem(int orderId)
        {
            repoDB.Delete(orderId);
        }

        public List<ItemModel> GetAllItems()
        {
            return repoDB.GetAll();
        }
    }
}
