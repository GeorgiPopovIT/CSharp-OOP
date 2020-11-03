using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGenerator
{
    public class Player
    {
        private string name;
        public Player(string name, Stats stats)
        {
            Name = name;
            Stats = stats;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }
        public Stats Stats { get; set; }

        public double OverallSkill => this.Stats.CalculateRating;
       
    }
}