using Raiding.Interfaces;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            BaseHero hero;
            int n = int.Parse(Console.ReadLine());
            while (heroes.Count != n)
            {
                var heroName = Console.ReadLine();
                var heroType = Console.ReadLine();
                switch (heroType)
                {
                    case "Druid":
                        hero = new Druid(heroName);
                        break;
                    case "Paladin":
                        hero = new Paladin(heroName);
                        break;
                    case "Rogue":
                        hero = new Rogue(heroName);
                        break;
                    case "Warrior":
                        hero = new Warrior(heroName);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!"); 
                        continue;
                }
                heroes.Add(hero);
            }

            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero1 in heroes)
            {
                hero1.CastAbility();
            }
            bool is_Winner = heroes.Sum(h => h.Power) >= bossPower;
            Console.WriteLine(is_Winner ? "Victory!" : "Defeat...");
        }
    }
}
