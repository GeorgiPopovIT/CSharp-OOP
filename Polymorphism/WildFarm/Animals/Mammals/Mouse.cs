using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {


        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }
        protected override double WeightPerFood => 0.10;
        public override string ProduceSound()
        {
            return "Squeak";
        }
        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Fruit))
            {
                InvalidEat(food);
            }
            FoodEaten += food.FoodQuantity;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
