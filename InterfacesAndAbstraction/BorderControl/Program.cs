using System;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IdNumber id = new IdNumber();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                id.Add(input[input.Length - 1]);
            }
            string i = Console.ReadLine();
            id.Checker(i);
        }
    }
}
