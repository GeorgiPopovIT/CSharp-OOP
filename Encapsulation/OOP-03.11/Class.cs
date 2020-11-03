using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_03._11
{
    class Class
    {
        public Class(int num)
        {
            Console.WriteLine(num);
        }
        public Class(char symbol, int num1, int num2)
        {
            Console.WriteLine(symbol + " " + num1 + " " + num2);
        }
        public Class(int num1, int num2)
        {
            if (num1 < 10)
            {
                Console.WriteLine("min");
            }
            else
            {
                Console.WriteLine("max");
            }

            if (num2 < 10)
            {
                Console.WriteLine("min");
            }
            else
            {
                Console.WriteLine("max");
            }
        }
    }
}
