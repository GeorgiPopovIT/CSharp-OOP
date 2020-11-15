using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgressInfo
{
    public class StreamProgressInfoClass
    {
        //replace File with IStream
        private IStream stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfoClass(IStream file)
        {
            this.stream = file;
        }
        public int CalculateCurrentPercent()
        {
            return (this.stream.BytesSent * 100) / this.stream.Length;
        }
    }
}
