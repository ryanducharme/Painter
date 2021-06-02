using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    //save image
    //resize image
    //different brushes
    //layers
    //custom colors
    //looper that can draw cool designs

    public partial class Form1 : Form
    {
        public List<Point> points = new List<Point>();
        Color clr = System.Drawing.Color.Black;
        bool mouseDown;
        Bitmap bm = new Bitmap(800,600);
        int brushSize;

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                brushSize = Int32.Parse(brushSizeTextBox.Text);
            }
            catch (FormatException)
            {
                //Console.WriteLine($"Unable to parse '{brushSize}'");
            }
            mouseDown = true;
            Point mousePoint = pictureBox1.PointToClient(Cursor.Position);
            points.Add(mousePoint);

            if(mouseDown == true && spirographCheckBox.Checked)
            {
                new Spirograph(
                Int32.Parse(incrementTextBox.Text),
                Int32.Parse(mousePoint.X.ToString()),
                Int32.Parse(mousePoint.Y.ToString()),
                Int32.Parse(radiusTextBox.Text)).
                Draw(Graphics.FromImage(bm), new Pen(clr, 1f));
            }
            pictureBox1.Refresh();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = pictureBox1.PointToClient(Cursor.Position);
            mousePosLabel.Text = mousePoint.X.ToString() + ", " + mousePoint.Y.ToString();
            if (mouseDown)
            {
                points.Add(mousePoint);
                pictureBox1.Refresh();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            bm.Save("..\\temp.png");
            points.Clear();
            pictureBox1.Refresh();
            
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(spirographCheckBox.Checked != true)
            {
                new PolyLine(points).Draw(Graphics.FromImage(bm), new Pen(clr, brushSize));
            }
            
            e.Graphics.DrawImage(bm,0, 0);
        }
        private void ColorSelectorButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            clr = btn.BackColor;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //bm.Dispose();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //create a new spirograph
            //new Spirograph(
            //    Int32.Parse(incrementTextBox.Text),
            //    Int32.Parse(offsetTextBox.Text),
            //    Int32.Parse(lengthTextBox.Text),
            //    Int32.Parse(widthTextBox.Text)).
            //    Draw(Graphics.FromImage(bm), new Pen(clr, 1));
            //new Spirograph().Draw(Graphics.FromImage(bm), new Pen(clr, 2));
            //pictureBox1.Refresh();

            new Spirograph(
                Int32.Parse(incrementTextBox.Text),
                Int32.Parse(yTextBox.Text), 
                Int32.Parse(xTextBox.Text),
                Int32.Parse(radiusTextBox.Text)).
                Draw(Graphics.FromImage(bm), new Pen(clr, 1f));
            pictureBox1.Refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bm.Dispose();
            File.Delete("..\\temp.png");
        }
    }
}
