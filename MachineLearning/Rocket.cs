using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MachineLearning
{
    public class Rocket : Drawable
    {
        int x;
        int y;
        int xSpd;
        int ySpd;
        Graphics rocketGraphic = new Graphics();

        public int Length { get; set; }
        public int xSpeed
        {
            get { return xSpeed; }
            set { xSpeed = value; }
        }
        public int ySpeed
        {
            get { return ySpeed; }
            set { ySpeed = value; }
        }

        public Rocket(int X, int Y)
        {
            x = X;
            y = Y;
            Length = 20;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            rocketGraphic.DrawLine(pen, x, y, x, y + Length);
            //graphics.DrawLine(pen, x, y, x, y + Length);
        }
    }
}
