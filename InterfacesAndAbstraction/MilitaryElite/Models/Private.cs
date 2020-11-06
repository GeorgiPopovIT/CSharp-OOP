
namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {
        public Private(string firstName, string lastName, string id, decimal salary)
            :base(firstName,lastName,id)
        {
            Salary = salary;
        }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}";
        }
    }
}
