using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class MyList : IMyList
    {
        public int Count => this.List.Count;

        public List<string> List { get; set; }

        public void Add(string item)
        {
            throw new NotImplementedException();
        }

        public void Remove(string item)
        {
            throw new NotImplementedException();
        }
    }
}
