using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Food
{
    internal class FoodModel
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Type { get; set; }

        public FoodModel() { }

        public FoodModel(int foodId, string name, float price, string type)
        {
            this.FoodId = foodId;
            this.Name = name;
            this.Price = price;
            this.Type = type;
        }
    }
}
