using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
       
        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }
        public void Add(string nameTeam, Player player)
        {
            if (nameTeam != this.Name)
            {
                throw new Exception($"Team {nameTeam} does not exist.");
            }
            players.Add(player);
        }
        public void Remove(string namePlayer)
        {
            var currPlayer = players.FirstOrDefault(p => p.Name == namePlayer);
            if (currPlayer == null)
            {
                throw new Exception($"Player {namePlayer} is not in {Name} team.");
            }
            players.Remove(currPlayer);
        }
        public double Rating =>  players.Count >0 ? Math.Round(players.Average(p => p.OverallSkill))
            : 0;
           
        public override string ToString()
        {
            return $"{Name} - {Rating}";
        }

    }
}
