﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough 
    {
        private string doughType;
        private double doughCalories;

        private string bakingTehnique;
        private double bakingTehCalories;

        private int weight;
        public Dough(string doughType, string bakingTehnique, int weight)
        {
            DoughType = doughType;
            BakingTehnique = bakingTehnique;
            Weight = weight;
        }
        public string DoughType
        {
            get => doughType;
            private set
            {
                if (value == "White")
                {
                    doughCalories = 1.5;
                }
                else if (value == "Wholegrain")
                {
                    doughCalories = 1.0;
                }
                else
                {
                    throw new Exception("Invalid type of dough.");
                }
                doughType = value;
            }
        }
        public string BakingTehnique
        {
            get => bakingTehnique;
            private set
            {
                if (value == "Crispy" || value == "crispy")
                {
                    bakingTehCalories = 0.9;
                }
                else if (value == "Chewy"|| value == "chewy")
                {
                    bakingTehCalories = 1.1;
                }
                else if (value == "Homemade" || value == "homemade")
                {
                    bakingTehCalories = 1.0;
                }
                bakingTehnique = value;
            }
        }
        public int Weight
        {
            get => weight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range[1..200].");
                }
                weight = value;
            }
        }

        public double Calculate() => (2 * Weight) * doughCalories * bakingTehCalories
        
    }
}
