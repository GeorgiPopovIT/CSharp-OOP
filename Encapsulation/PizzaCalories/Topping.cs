using System;


namespace PizzaCalories
{
    public class Topping
    {
        private double calories;
        private string type;
        private int weight;
        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }
        public string Type
        {
            get => type;
            private set
            {
                if (value == "meat" || value == "Meat")
                {
                    calories = 1.2;
                }
                else if (value == "veggies" || value == "Veggies")
                {
                    calories = 0.8;
                }
                else if (value == "cheese" || value == "Cheese")
                {
                    calories = 1.1;
                }
                else if (value == "sauce" || value == "Sauce")
                {
                    calories = 0.9;
                }
                else
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                type = value;
            }
        }
        public int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{type} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }
        public double Calculate() => 2 * (calories * Weight);
    }
}
