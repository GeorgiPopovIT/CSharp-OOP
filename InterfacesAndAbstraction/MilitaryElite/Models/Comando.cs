using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Comando :SpecialisedSoldier, IComando
    {
        public Comando(string firstName, string lastName, string id, decimal salary, string corps)
            :base(firstName,lastName,id,salary,corps)
        {
            Missions = new List<Mission>();
        }
        public void CompleteMission(Mission mission)
        {
            mission.State = "Finished";
        }
        public List<Mission> Missions { get; set; }
    }
}
