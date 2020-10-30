using NeedForSpeed.Motorcycle;
using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RaceMotorcycle motorcycle = new RaceMotorcycle(150,100);
            motorcycle.Drive(50);
        }
    }
}
