using System;


namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
       
    }
}
