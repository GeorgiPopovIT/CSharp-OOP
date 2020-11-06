using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var telNumbers = Console.ReadLine().Split().ToList();
            var smartphone = new Smartphone();
            var number = new StationaryPhone();
            foreach (var item in telNumbers)
            {
                try
                {
                    if (item.Length == 10)
                    {
                        Console.WriteLine(smartphone.Calling(item));
                    }
                    else if(item.Length == 7)
                    {
                        Console.WriteLine(number.Calling(item));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var urls = Console.ReadLine().Split().ToList();
            foreach (var item in urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browsing(item));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
