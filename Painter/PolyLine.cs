using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Painter
{
    //draw on picture box
    //save data from picture onto bitmap
    //draw bitmap inside picture box
    //clear the drawing data from the picture box and keep bitmap
    class PolyLine : Shape
    {
        List<Point> polyLine = new List<Point>();
        public PolyLine(List<Point> p)
        {
            
            polyLine.AddRange(p);
        }
        public override void Draw(Graphics g, Pen pen)
        {
            GraphicsPath path = new GraphicsPath();
            if (polyLine.Count >= 2)
            {
                path.AddLines(polyLine.ToArray());
                g.DrawPath(pen, path);
            }
            else if(polyLine.Count < 2 && polyLine.Count > 0)
            {
                var brush = new SolidBrush(pen.Color);
                var rect = new RectangleF(polyLine[0].X, polyLine[0].Y, pen.Width, pen.Width);
                g.FillRectangle(brush, rect);
            }
            
            
            
        }
    }
}
