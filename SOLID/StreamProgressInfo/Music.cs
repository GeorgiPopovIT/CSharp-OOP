﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgressInfo
{
    public class Music : IStream
    {
        // create interface
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
            this.BytesSent = bytesSent;
        }
        public int Length { get; set; }
        public int BytesSent { get; set; }
    }
}
