using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
        string IPerson.GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            IResident resident = new Citizen(Name);
            IPerson person = new Citizen(Name);
            sb
                .AppendLine(person.GetName())
                .AppendLine(resident.GetName());

            return sb.ToString().Trim();
        }
    }
}
