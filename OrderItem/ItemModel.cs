using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.OrderItem
{
    internal class ItemModel
    {
        public int OrderId { get; set; }
        public int FoodId { get; set; }
        public float Quantity { get; set; }

        public ItemModel() { }

        public ItemModel(int orderId, int foodId, float quantity)
        {
            this.OrderId = orderId;
            this.FoodId = foodId;
            this.Quantity = quantity;
        }
    }
}
