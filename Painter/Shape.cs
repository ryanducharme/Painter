using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Painter
{
    abstract class Shape
    {
        //List<Point> shape = new List<Point>();
        //Color color;

        public abstract void Draw(Graphics g, Pen pen);
    }
}
