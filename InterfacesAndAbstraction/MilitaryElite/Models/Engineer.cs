
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, string id, decimal salary, string corps)
            :base(firstName,lastName,id,salary,corps)
        {
            Repairs = new List<Repair>();
        }
        public List<Repair> Repairs { get; set ; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {base.Salary}")
                .AppendLine($"Corps: {base.Corps}");
            foreach (var repair in Repairs)
            {
                sb.Append(repair.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
