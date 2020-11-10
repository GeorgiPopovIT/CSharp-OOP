using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Interfaces;

namespace Vehicle.Models
{
    public class Car : IProps
    {
        private int tankCapacity;
        public Car(double fuelQuantity, double fuelConsumption, int tankCapcity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapcity;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public int TankCapacity
        {
            get => tankCapacity;
            set
            {
                if (value > FuelQuantity)
                {
                    value = 0;
                }

                this.tankCapacity = value;
            }
        }
        public string Drive(double distance)
        {
            var ost = FuelQuantity - distance * (FuelConsumption + 0.9);
            if (ost >= 0)
            {
                this.FuelQuantity = ost;
                return $"Car travelled {distance} km";
            }
            return "Car needs refueling";
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + liters <= TankCapacity)
                this.FuelQuantity += liters;
            else
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
