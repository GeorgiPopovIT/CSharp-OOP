using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape = new Rectangle(5, 2);
            Console.WriteLine(shape.Draw());
        }
    }
}
