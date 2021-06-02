using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private int X { get; set; }
        private int Y { get; set; }
        private int Radius { get; set; }
        public Spirograph(int increment, int x, int y, int radius)
        {
            Increment = increment;
            X = x;
            Y = y;
            Radius = radius;
        }
        public Spirograph() { }
        public override void Draw(Graphics g, Pen pen)
        {
            
            var h = X;
            var k = Y;
            var r = Radius;
            var matrix = new Matrix();
            float ellipseCenterX = X + (r * 2);
            float ellipseCenterY = Y + (r * 2);
            //double theta = 0;
            var step = 2*Math.PI/Increment;

            float rotation = 1f;
            for (int i = 0; i < 1; i++)
            {
                
                for (var theta = 0.0; theta < 2 * Math.PI; theta += step)
                {
                    var x = h + r * Math.Cos(theta);
                    var y = k - r * Math.Sin(theta);
                    

                    var rectf = new RectangleF((float)x, (float)y, 20, 20);
                    //g.RotateTransform(1f);
                    //g.DrawEllipse(pen, rectf);

                    matrix.RotateAt(rotation, new PointF(ellipseCenterX, ellipseCenterY));
                    g.Transform = matrix;
                    //Draw the rotated ellipse
                    Rectangle rec = new Rectangle((int)x, (int)y, r * 2, r * 2);
                    g.DrawEllipse(pen, rec);

                    rotation+=10;
                    //Rotate back to normal around the same point</pre>
                    //matrix.RotateAt(-rotation, new PointF(ellipseCenterX, ellipseCenterY));
                    //g.Transform = matrix;

                }
            }

            
        }
    }
}
