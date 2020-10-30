using System;
using System.Text;

namespace Animals
{
    public class Animals
    {
        private string name;
        public Animals(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get => Age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                Age = value;
            }
        }
        public string Gender
        {
            get => Gender;
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input");
                }
                Gender = value;
            }
        }

        public virtual string ProduceSound()
        {
            return " ";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine(ProduceSound());

            return sb.ToString().Trim();
        }
    }
}
