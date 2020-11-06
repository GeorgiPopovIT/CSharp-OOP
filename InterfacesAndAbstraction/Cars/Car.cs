using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public abstract class Car :ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"{Color} {GetType().Name} {Model}")
                .AppendLine(this.Start())
                  .AppendLine(this.Stop());
            return sb.ToString().Trim();
        }
    }
}
