using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public StationaryPhone()
        {

        }
        public string Calling(string value)
        {
            if (!value.All(c => char.IsDigit(c)))
            {
                throw new Exception("Invalid number!");
            }
            return $"Dialing... {value}";
        }
    }
}
