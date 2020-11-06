

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary,string corps)
            :base(firstName,lastName,id,salary)
        {
            Corps = corps;
        }
        public string Corps { get; set; }
    }
}
