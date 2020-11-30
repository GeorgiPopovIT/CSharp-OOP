using System;
using System.Collections.Generic;
using System.Text;
using TemplatePattern.Contratcts;

namespace TemplatePattern.Models
{
    public class Sourdough : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Gathering Ingredients for Sourdough Bread.");
        }

        public override void MixIngredients()
        {
            Console.WriteLine("Baking the Sourdougn Bread. (20 minutes)");
        }
    }
}
