using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    public class Student
    {
        private string name;
        public Student(string name)
        {
            Name = name;
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (value.Any(char.IsDigit))
                {
                    throw new InvalidPersonNameException($"{value} -> Invalid name");
                }
                this.name = value;
            }
        }
    }
}
