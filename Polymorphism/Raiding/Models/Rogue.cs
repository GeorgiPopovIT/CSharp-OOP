using Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override int Power { get; set; } = 80;

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} hit for {Power} damage");
        }
    }
}
