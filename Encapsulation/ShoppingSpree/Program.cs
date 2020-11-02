using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();
            try
            {
                var personInput = Console.ReadLine()
                    .Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < personInput.Length; i += 2)
                {
                    var person = new Person(personInput[i], int.Parse(personInput[i + 1]));
                    people.Add(person);
                }
                var productInput = Console.ReadLine()
                   .Split(new string[] { ";", "=" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < productInput.Length; i += 2)
                {
                    var product = new Product(productInput[i], int.Parse(productInput[i + 1]));
                    products.Add(product);
                }

                while (true)
                {
                    string[] input = Console.ReadLine().Split().ToArray();
                    if (input[0] == "END")
                    {
                        break;
                    }
                    var person = people.FirstOrDefault(p => p.Name == input[0]);
                    var product = products.FirstOrDefault(p => p.Name == input[1]);
                    person.BuyProduct(product);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
