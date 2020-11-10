using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Foods;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal;
            Food food;
            while (true)
            {
                string[] animalInfo = Console.ReadLine().Split().ToArray();
                if (animalInfo[0] == "End")
                    break;
                try
                {
                    switch (animalInfo[0])
                    {
                        case nameof(Cat):
                            animal = new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                            break;
                        case nameof(Dog):
                            animal = new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                            break;
                        case nameof(Mouse):
                            animal = new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                            break;
                        case nameof(Tiger):
                            animal = new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                            break;
                        case nameof(Hen):
                            animal = new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                            break;
                        case nameof(Owl):
                            animal = new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                            break;
                        default:
                            throw new Exception($"{animalInfo[0]} is not a valid Animal type.");
                    }
                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                string[] foodInfo = Console.ReadLine().Split().ToArray();
                try
                {
                    switch (foodInfo[0])
                    {
                        case nameof(Vegetable):
                            food = new Vegetable(int.Parse(foodInfo[1]));
                            break;
                        case nameof(Fruit):
                            food = new Fruit(int.Parse(foodInfo[1]));
                            break;
                        case nameof(Meat):
                            food = new Meat(int.Parse(foodInfo[1]));
                            break;
                        case nameof(Seeds):
                            food = new Seeds(int.Parse(foodInfo[1]));
                            break;
                        default:
                            throw new Exception($"{foodInfo[0]} is not a valid Food type.");
                    }
                    animal.ValidateFood(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}

