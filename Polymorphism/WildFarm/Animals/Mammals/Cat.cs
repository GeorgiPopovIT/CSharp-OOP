using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Cat : Feline
    {
        public Cat(string name ,double weight, string livingRegion, string breed)
            :base(name,weight,livingRegion,breed)
        {
           
        }

        protected override double WeightPerFood => 0.30;

        public override string ProduceSound()
        {
           return "Meow";
        }


        public override void ValidateFood(Food food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Vegetable) && type != nameof(Meat))
            {
                InvalidEat(food);
            }
            FoodEaten += food.FoodQuantity;
        }
    }
}
