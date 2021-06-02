using System;
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
            //double theta = 0;
            var step = 2*Math.PI/Increment;

            for(int i = 0; i < 100; i++)
            {
                for (var theta = 0.0; theta < 2 * Math.PI; theta += step)
                {
                    var x = h + r * Math.Cos(theta);
                    var y = k - r * Math.Sin(theta);

                    var rectf = new RectangleF((float)x, (float)y, 20, 20);
                    //g.RotateTransform(30f);
                    g.DrawEllipse(pen, rectf);
                    //g.TranslateTransform((float)x, (float)y);
                }
            }
            

        }
    }
}
