using System;

namespace Fixing_Vol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            //added try-catch block
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine($"{num1} x {num2} = {result}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
