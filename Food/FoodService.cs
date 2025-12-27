using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Food
{
    internal class FoodService
    {
        private FoodRepoDB repoDB = new FoodRepoDB();

        public void AddFood(FoodModel food)
        {
            repoDB.Create(food);
        }

        public void UpdateFood(FoodModel food)
        {
            repoDB.Update(food);
        }

        public void DeleteFood(int id)
        {
            repoDB.Delete(id);
        }

        public List<FoodModel> GetAllFood()
        {
            return repoDB.GetAll();
        }
    }
}
