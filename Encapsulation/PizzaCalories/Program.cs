using System;
using System.Linq;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                Dough dough = null;
                try
                {
                    dough = new Dough(input[1], input[2], int.Parse(input[3]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                result = dough.Calculate();
            }
            Console.WriteLine(result);
        }
    }
}
