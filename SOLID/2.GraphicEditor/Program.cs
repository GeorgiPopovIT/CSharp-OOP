using System;

namespace P02.Graphic_Editor
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Circle();
            Console.WriteLine(shape);
        }
    }
}
