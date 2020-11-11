using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Gin40");
            }
            catch (InvalidPersonNameException e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
