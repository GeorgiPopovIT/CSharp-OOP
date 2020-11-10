using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            :base(name,weight,wingSize)
        {
        }

        protected override double WeightPerFood =>0.25;

        public override string ProduceSound()
        {
           return "Hoot Hoot";
        }
        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                InvalidEat(food);
            }
            FoodEaten += food.FoodQuantity;
        }
    }
}
