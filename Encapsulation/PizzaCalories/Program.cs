using System;
using System.Linq;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPizza = Console.ReadLine().Split(";");
            Pizza pizza = new Pizza(inputPizza[1]);

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                try
                {
                    if (input[0] == "Dough")
                    {
                        Dough dough = new Dough(input[1], input[2], int.Parse(input[3]));
                    }
                    else if (input[0] == "Topping")
                    {
                        Topping topping = new Topping(input[1], int.Parse(input[2]));
                        pizza.Add(topping);
                    }
                    pizza.Sum();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            Console.WriteLine(pizza);
        }
    }
}
