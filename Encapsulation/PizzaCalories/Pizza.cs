using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private Dough dough;
        private double sum;
        private string name;
        private List<Topping> toppings;
        public Pizza(string name)
        {
            this.name = name;
            this.toppings = new List<Topping>();
        }
        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }
        public void Add(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            this.toppings.Add(topping);
        }
        public Dough Dough
        {
            get => this.dough;
            set
            {
                this.dough = value;
            }
        }
        public void Sum()
        {
            sum += dough.Calculate();
            foreach (Topping item in toppings)
            {
                sum += item.Calculate();
            }
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.sum:F2} Calories.";
        }
    }
}
