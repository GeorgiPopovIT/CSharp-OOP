
using System.Text;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public int Battery { get; set; }
        public Tesla(string model, string color, int battery)
            : base(model, color)
        {
            Battery = battery;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"{Color} {GetType().Name} {Model} with {Battery} Batteries")
                .AppendLine(this.Start())
                  .AppendLine(this.Stop());
            return sb.ToString().Trim();
        }
    }
}
