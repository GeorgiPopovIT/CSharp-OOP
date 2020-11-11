using System;
using System.Collections.Generic;
using System.Text;

namespace ValidPerson
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName
        {
            get => this.firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The first name cannot be empty");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get => this.lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The last name cannot be empty");
                }
                this.lastName = value;
            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                if (value < 0 || 120 < value)
                {
                    throw new ArgumentOutOfRangeException("value", "Age should be in range [0 ... 120].");
                }
                this.age = value;
            }
        }
    }
}
