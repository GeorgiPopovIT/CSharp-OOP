
namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string name, int workedHour)
        {
            Name = name;
            WorkedHour = workedHour;
        }
        public string Name { get; set; }
        public int WorkedHour { get; set; }

        public override string ToString()
        {
            return $"Part Name: {Name} Hours Worked: {WorkedHour}";
        }
    }
}
