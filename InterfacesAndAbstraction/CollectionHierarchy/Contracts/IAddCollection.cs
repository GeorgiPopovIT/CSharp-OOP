using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IAddCollection
    {
        public List<string> List { get; }
        virtual void Add(string item)
        {
            List.Insert(0, item);
        }
    }
}
