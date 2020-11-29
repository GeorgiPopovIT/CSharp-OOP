using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Car
    {
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Car Type: {Type}, Color: {Color},Number of doors: {NumberOfDoors}, Manufacturer in {City}, at address: {Address}";
        }
    }
}
