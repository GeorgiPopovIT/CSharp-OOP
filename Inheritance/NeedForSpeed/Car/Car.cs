﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Car
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
            :base(horsePower,fuel)
        {

        }
        public override double FuelConsumption  => 3;
    }
}
