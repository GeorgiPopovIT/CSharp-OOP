using CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy.Models
{
    public class AddCollection :IAddCollection
    {
        private List<string> list;

        public AddCollection(params string[] l)
        {
           
        }
        public void Add(string item)
        {
            if(list.Count < 100)
            list.Insert(0,item);
        }
    }
}
