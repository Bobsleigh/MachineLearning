using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Windows;

namespace MachineLearning
{
    public class Rocket : Drawable
    {

        Vector pos = new Vector(0, 0);
        Vector shape = new Vector(0, 0);
        Vector speed = new Vector(1, 1);
        Vector acc = new Vector(0, 0);
        /*                   
        int xSpd;
        int ySpd;
        int xAcc;
        int yAcc;
        double x;
        double y;
        double x2;
        double y2;
        */
        double angle;

        public double Length { get; set; }

        public double xSpeed
        {
            get { return speed.X; }
            set { speed.X = value; }
        }

        public double ySpeed
        {
            get { return speed.Y; }
            set { speed.Y = value; }
        }

        public Vector Pos
        {
            get
            {
                return pos;
            }
            set
            {
                pos = value;
            }
        }

        public Vector Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public Vector Acc
        {
            get
            {
                return acc;
            }
            set
            {
                acc = value;
            }
        }

        public double Angle
        {
            get { return angle; }
            set
            {
                Vector endPoint = RotatePoint(shape, pos, value - angle);
                shape.X = endPoint.X;
                shape.Y = endPoint.Y;
                angle = value;
            }
        }

        public Rocket(double X, double Y)
        {
            pos.X = X;
            pos.Y = Y;
            Length = 20;
            shape.X = X;
            shape.Y = Y + Length;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, (float)pos.X, (float)pos.Y, (float)shape.X, (float)shape.Y);
        }

        public void Update()
        {
            pos = Vector.Add(pos, speed);
            shape = Vector.Add(shape, speed);
            speed = Vector.Add(speed, acc);
            acc = Vector.Multiply(0, acc);
        }

        public void Rotate(double angleInDeg)
        {
            Angle += angleInDeg;
        }

        private Vector RotatePoint(Vector pointToRotate, Vector centerPoint, double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);
            double cosTheta = Math.Cos(angleInRadians);
            double sinTheta = Math.Sin(angleInRadians);
            return new Vector
            {
                X =
                    (cosTheta * (pointToRotate.X - centerPoint.X) -
                    sinTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.X),
                Y =
                    (sinTheta * (pointToRotate.X - centerPoint.X) +
                    cosTheta * (pointToRotate.Y - centerPoint.Y) + centerPoint.Y)
            };
        }
    }
}
