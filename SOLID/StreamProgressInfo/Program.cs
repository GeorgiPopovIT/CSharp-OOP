using System;

namespace StreamProgressInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStream stream = new Music("david", "sechst", 8, 32);
            StreamProgressInfoClass progressInfo = new StreamProgressInfoClass(stream);
            Console.WriteLine(progressInfo.CalculateCurrentPercent());
        }
    }
}
