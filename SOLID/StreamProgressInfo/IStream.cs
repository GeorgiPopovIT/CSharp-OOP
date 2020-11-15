using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgressInfo
{
    public interface IStream
    {
        int Length { get; set; }
        int BytesSent { get; set; }
    }
}
