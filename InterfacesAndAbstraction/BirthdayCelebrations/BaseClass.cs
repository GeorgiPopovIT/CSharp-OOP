using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public class BaseClass
    {
        public BaseClass(string birthday)
        {
            BirthdayDate = birthday;
        }
       public  string BirthdayDate { get; set; }
    }
}
