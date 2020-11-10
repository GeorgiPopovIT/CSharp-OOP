using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Food
    {
        public Food(int foodQuantity)
        {
            FoodQuantity = foodQuantity;
        }
        public int FoodQuantity { get; set; }
    }
}
