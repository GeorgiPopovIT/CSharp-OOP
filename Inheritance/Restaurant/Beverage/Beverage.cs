

namespace Restaurant.Beverage
{
   public class Beverage : Product
    {
        public Beverage(string name, decimal price,double mililitres)
            :base(name,price)
        {
            Mililitres = mililitres;
        }
        public  double Mililitres { get; set; }
    }
}
