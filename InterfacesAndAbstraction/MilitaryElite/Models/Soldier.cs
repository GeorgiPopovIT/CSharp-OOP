

namespace MilitaryElite
{
    public class Soldier
    {
        public Soldier(string firstName, string lastName, string id)

        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
    }
}
