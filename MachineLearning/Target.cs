using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineLearning
{
    public class Target : Drawable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public Target(int X, int Y)
        {
            x = X;
            y = Y;
            height = 10;
            width = 10;
        }

        public Target(int X, int Y, int Height, int Width)
        {
            x = X;
            y = Y;
            height = Height;
            width = Width;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, x, y, width, height);
        }
    }
}
