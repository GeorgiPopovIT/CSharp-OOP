using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var sqrtRoot = new SquareRoot(int.Parse(Console.ReadLine()));
                Console.WriteLine(Math.Sqrt(sqrtRoot.Number));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
