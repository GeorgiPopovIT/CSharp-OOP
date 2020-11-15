using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgressInfo
{
    public class File : IStream
    {
        // crete interface
        private string name;
        public File(string name, int length, int bytesSent)
        {
            this.name = name;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; set; }
        public int BytesSent { get; set; }
    }
}
