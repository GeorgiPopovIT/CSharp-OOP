using System;
using System.Collections.Generic;
using System.Text;

namespace SquareRoot
{
    public class SquareRoot
    {
        private int number;
        public SquareRoot(int number)
        {
            Number = number;
        }
        public int Number
        {
            get => number;
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid number");
                }
                number = value;
            }
        }
    }
}
