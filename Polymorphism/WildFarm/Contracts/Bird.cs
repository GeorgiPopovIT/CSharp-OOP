using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight,double wingSize)
            :base(name,weight)
        {
            WingSize = wingSize;
        }
        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight + FoodEaten * WeightPerFood}, {FoodEaten}]";
        }
        public double WingSize { get; set; }
    }
}
