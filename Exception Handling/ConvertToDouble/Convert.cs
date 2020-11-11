using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertToDouble
{
    public static class SystemConvert
    {
        public static void Create(string niz)
        {
            try
            {
                double conv = Convert.ToDouble(niz);
                Console.WriteLine(conv);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
