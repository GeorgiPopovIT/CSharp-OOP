using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        protected abstract double WeightPerFood { get; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, ";
        }
        public void InvalidEat(Food food)
        {
            throw new Exception($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        public abstract string ProduceSound();
        public abstract void ValidateFood(Food food);
    }
}
