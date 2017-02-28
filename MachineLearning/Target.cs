using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineLearning
{
    class Target : Drawable
    {
        int x;
        int y;
        int height;
        int width;

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
