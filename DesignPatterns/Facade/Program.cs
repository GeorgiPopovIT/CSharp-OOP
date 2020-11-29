using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
             .Info
                .WithType("BMW")
                .WithColor("Black")
                .WithNumbersOfDoors(5)
             .Built
                .InCity("Plovidv")
                .AtAddress("ul.sdd")
                .Build();

            Console.WriteLine(car);
        }
    }
}
