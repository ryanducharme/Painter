﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
    class Spirograph : Shape
    {
        //Loop through the points of a circle and draw a shape at that point, continue though all 360 degrees of the circle.
        //https://www.mathopenref.com/coordparamcircle.html
        private int Increment { get; set; }
        private int Offset { get; set; }
        private int Length { get; set; }
        private int Width { get; set; }
        public Spirograph(int increment, int offset, int length, int width)
        {
            Increment = increment;
            Offset = offset;
            Length = length;
            Width = width;
        }
        public override void Draw(Graphics g, Pen pen)
        {
            for(int i = 0; i < Increment; i++)
            {
                //g.DrawRectangle(pen, i += Offset, i += Offset, Length, Width);
                g.DrawEllipse(pen, i += Offset, i += Offset, Length, Width);
            }
        }
    }
}