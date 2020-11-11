using System;
using System.Collections.Generic;
using System.Text;

namespace EnterNumbers
{
    public class ValidateNumbers
    {
        public void ReadNumber(int start, int end)
        {
            //int prevNumber = start;
            for (int i = 0; i < 9; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= start && number <= end)
                {
                    Console.WriteLine(number);
                    start = number;
                }
                else
                {
                    throw new ArgumentException("Invalid number");
                }
            }
        }
    }
}
