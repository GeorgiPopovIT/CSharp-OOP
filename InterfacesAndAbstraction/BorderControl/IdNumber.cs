using System;
using System.Collections.Generic;
using System.Text;
namespace BorderControl
{
    public class IdNumber : ICheckerId
    {
        private List<string> ids;
        public IdNumber()
        {
            ids = new List<string>();
        }
        public void Add(string id)
        {
            ids.Add(id);
        }
        public void Checker(string id)
        {
            foreach (var item in ids)
            {
                string r = item.Substring(item.Length - id.Length);
                if (r == id)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
