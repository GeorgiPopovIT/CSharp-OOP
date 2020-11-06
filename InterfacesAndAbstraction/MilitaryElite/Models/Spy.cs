
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string firstName, string lastName, string id, int codeNumber)
            : base(firstName, lastName, id)
        {
            CodeNumber = codeNumber;
        }
        public int CodeNumber { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id}")
                 .AppendLine($"Code Number: {CodeNumber}");

            return sb.ToString().Trim();
        }
    }
}
