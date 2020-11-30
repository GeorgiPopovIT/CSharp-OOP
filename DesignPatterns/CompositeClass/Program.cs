using Composite;
using System;

namespace CompositeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("Samsung",256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootbox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("TruckToy", 60);
            var plainToy = new SingleGift("PlainToy", 40);
            rootbox.Add(truckToy);
            rootbox.Add(plainToy);
            var childBox = new CompositeGift("ChildBox", 0);
            var soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);
            rootbox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootbox.CalculateTotalPrice()}");
        }
    }
}
