using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string cheese;
        private string meat;
        private string veggies;
        public Sandwich(string bread,string cheese,string meat,string veggies)
        {
            this.bread = bread;
            this.cheese = cheese;
            this.meat = meat;
            this.veggies = veggies;
        }
        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine($"Cloning sandwich with ingredients: {ingredientList}");

            return MemberwiseClone() as SandwichPrototype;
        }
        private string GetIngredientList()
        {
            return $"{this.bread}, {this.cheese}, {this.meat}, {this.veggies}";
        }
    }
}
