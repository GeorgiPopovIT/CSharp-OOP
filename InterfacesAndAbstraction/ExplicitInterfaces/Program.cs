using System;
using System.Linq;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                var name = input[0];
              
                Citizen citizen = new Citizen(name);
                //IResident citizen1 = new Citizen(name);
                //Console.WriteLine(citizen.GetName());
                //Console.WriteLine(citizen1.GetName());

                Console.WriteLine(citizen);
            }
        }
    }
}
