using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
    class Circle : Shape
    {
        List<Point> polyCircle = new List<Point>();
        Point Latest { get; set; }
        Color clr;
        public Circle(List<Point> p)
        {
            polyCircle.AddRange(p);
        }
        public override void Draw(Graphics g, Pen pen)
        {
            GraphicsPath path = new GraphicsPath();
            foreach(Point p in polyCircle)
            {
                path.AddEllipse(p.X, p.Y, pen.Width, pen.Width);
            }
            
            
            g.DrawPath(pen, path);
        }


    }
}
