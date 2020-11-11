using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            ValidateNumbers num = new ValidateNumbers();
            num.ReadNumber(start, end);
        }
        
    }
}
