using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Contracts
{
    public interface IAddAndRemove : IAddCollection
    {
        void Remove(string item);
    }
}
