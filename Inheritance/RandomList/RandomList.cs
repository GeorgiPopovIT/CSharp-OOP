using System;
using System.Collections.Generic;


namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rand;
        public string RandomString()
        {
            int index = rand.Next(0, this.Count);
            this.RemoveAt(index);
            return this[index];
        }
    }
}
