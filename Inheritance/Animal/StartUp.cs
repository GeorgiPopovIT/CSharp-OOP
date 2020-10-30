using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>();

            while (true)
            {
                string inputType = Console.ReadLine();
                if (inputType == "Beast!")
                {
                    break;
                }
                var currAnimal = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = currAnimal[0];
                var age = int.Parse(currAnimal[1]);
                string gender = null;

                if (currAnimal.Length >= 3 )
                {
                    gender = currAnimal[2];
                }

                Animals animal;
                if (inputType == "Cat")
                {
                    animal = new Cat(name, age, gender);
                }
                else if (inputType == "Dog")
                {
                    animal = new Dog(name, age, gender);
                }
                else if (inputType == "Frog")
                {
                    animal = new Frog(name, age, gender);
                }
                else if (inputType == "Kitten")
                {
                    animal = new Kitten(name, age);
                }
                else if (inputType == "Tomcat")
                {
                   animal = new Tomcat(name, age);
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
                animals.Add(animal);
            }
            foreach (Animals animals1 in animals)
            {
                Console.WriteLine(animals1);
            }
        }
    }
}
