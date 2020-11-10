using Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override int Power { get; set; } = 100;

        public override void CastAbility()
        {
            Console.WriteLine($"{GetType().Name} - {Name} healed for {Power}");
        }
    }
}
