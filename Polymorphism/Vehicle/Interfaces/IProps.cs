using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Interfaces
{
    public interface IProps
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }
        int TankCapacity { get; set; }
        string Drive(double distance);
        void Refuel(double liters);
        abstract string ToString();
    }
}
