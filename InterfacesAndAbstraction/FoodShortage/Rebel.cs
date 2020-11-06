using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    class Rebel : IBuyer
    {
        public string Name { get; set; }
        public int Food { get; set; } = 0;
        public Rebel(string name,int food)
        {
            Name = name;
            Food = food;
        }
        public void BuyFodd()
        {
            this.Food += 5;
        }
    }
}
