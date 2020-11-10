using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood => 1.00;

        public override string ProduceSound()
        {
            return "ROAR!!!";
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
