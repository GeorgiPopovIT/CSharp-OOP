using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                if (input.Length == 4)
                {
                    list.Add(new Citizen(input[0], 0));
                }
                else if (input.Length == 3)
                {
                    list.Add(new Rebel(input[0], 0));
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var buyer = list.FirstOrDefault(b => b.Name == input);
                if (buyer != null)
                {
                    buyer.BuyFodd();
                }
            }
            Console.WriteLine(list.Sum(b => b.Food));
        }
    }
}
