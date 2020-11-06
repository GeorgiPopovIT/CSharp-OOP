using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            HashSet<Private> privates = new HashSet<Private>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                if (input[0] == "Private")
                {
                    var privater = new Private(input[2], input[3], input[1], decimal.Parse(input[4]));
                    privates.Add(privater);
                    Console.WriteLine(privater.ToString());
                }
                else if (input[0] == "Commando")
                {
                    var comandos = new Comando(input[2],input[3],input[1],decimal.Parse(input[4]),input[5]);
                    
                }
                
            }
        }
    }
}
