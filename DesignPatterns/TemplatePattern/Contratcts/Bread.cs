using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Contratcts
{
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();
        public virtual void Slide()
        {
            Console.WriteLine("Slicing the " + GetType().Name + " braed");
        }
        public void Make()
        {
            MixIngredients();
            Bake();
            Slide();
        }
    }
}
