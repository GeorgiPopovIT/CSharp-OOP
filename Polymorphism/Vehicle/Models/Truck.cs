using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Interfaces;

namespace Vehicle.Models
{
    public class Truck : IProps
    {
        private int tankCapacity;
        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
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
            var ost = FuelQuantity - distance * (FuelConsumption + 1.6);
            if (ost >= 0)
            {
                FuelQuantity = ost;
                return $"Truck travelled {distance} km";
            }
            return "Truck needs refueling";
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + liters * 0.95 <= TankCapacity)
                this.FuelQuantity += liters * 0.95;
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
