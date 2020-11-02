using System;
using System.Text;

namespace Animals
{
    public class Animals
    {
        private string name;
        private int age;
        private string gender;
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
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                this.age = value;

            }
        }
        public string Gender
        {
            get => this.gender;
            set
            {
                if (value != "Male" && value != "Female")
                {
                    Console.WriteLine("Invalid input");

                }
                this.gender = value;
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
