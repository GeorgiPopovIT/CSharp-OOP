using Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override int Power { get; set; } = 100;

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} hit for {Power} damage");
        }
    }
}
