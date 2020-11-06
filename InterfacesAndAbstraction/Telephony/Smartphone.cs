using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowsable
    {
        public Smartphone()
        {
            
        }
        public string Browsing(string n)
        {
            if (n.Any(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid URL!");
            }
            return $"Browsing: {n}!";
        }

        public string Calling(string n)
        {
            if (!n.All(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid number!");
            }
            return $"Calling... {n}";
        }
    }
}
