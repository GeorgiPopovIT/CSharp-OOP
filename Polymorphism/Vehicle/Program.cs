using System;
using System.Linq;
using Vehicle.Interfaces;
using Vehicle.Models;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split().ToArray();
            var truckInput = Console.ReadLine().Split().ToArray();
            var busInput = Console.ReadLine().Split().ToArray();

            IProps car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]),int.Parse(carInput[3]));
            IProps truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), int.Parse(truckInput[3]));
            IProps bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), int.Parse(busInput[3]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(double.Parse(command[2])));
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    Bus emptyBus = (Bus)bus;
                    Console.WriteLine(emptyBus.DriveEmpty(double.Parse(command[2])));
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
