﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public class Rectangle : IShape
    {
        public override string ToString()
        {
            return $"I'm {this.GetType().Name}"; ;
        }
    }
}
