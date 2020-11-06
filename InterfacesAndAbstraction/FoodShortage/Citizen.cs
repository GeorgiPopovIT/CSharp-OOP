using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        public int Food { get; set; } = 0;
        public Citizen(string name,int food)
        {
            Name = name;
            Food = food;
        }
        public void BuyFodd()
        {
            Food += 10;
        }
    }
}
