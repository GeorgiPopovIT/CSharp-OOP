
namespace MilitaryElite
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }
        public string CodeName { get; set; }
        public string State { get; set; }

        public override string ToString()
        {
            return $"Code {CodeName}: Freedom State: {State}";
        }
    }
}
