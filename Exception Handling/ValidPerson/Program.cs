using System;

namespace ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);
            try
            {
                Person noName = new Person(string.Empty, "Goshev", 31);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Arg ex:{e.Message}");
            }

           // Person noLastName = new Person("Ivan", null, 63);
            try
            {
                Person negativeAges = new Person("Stoyan", "Kolev", -1);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Exception thrown: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Execption thrown: {e.Message}");
            }
            Person tooOldPerson = new Person("Iskren", "Ivanov", 121);
        }
    }
}
