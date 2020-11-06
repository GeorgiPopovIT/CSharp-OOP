using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IContainsc> list = new List<IContainsc>();
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] {" " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                if (input[0] == "Citizen")
                {
                    list.Add(new Citizen(input[input.Length - 1]));
                }
                else if (input[0] == "Pet")
                {
                    list.Add(new Pet(input[input.Length - 1]));
                }
            }
            string lastDigits = Console.ReadLine();
           
                list.Where(p => p.BirthdayDate.EndsWith(lastDigits))
                      .ToList().ForEach(c => Console.WriteLine(c.BirthdayDate));
        }
    }
}
