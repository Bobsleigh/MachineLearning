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
        Vector speed = new Vector(0, 0);
        Vector acc = new Vector(0, 0);
        int lifespan;
        Dna genes;

        public bool Completed { get; set; }
        public double finalFitness { get; set; }

        double angle;

        public double Length { get; set; }

        public int TimeCompleted { get; set; }

        public Dna DNA
        {
            get { return genes; }
            set { genes = value; }
        }

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
        public Rocket(int lifesp)
        {
            speed.X = 0;
            speed.Y = 0;

            pos.X = 300;
            pos.Y = 300;
            Length = 20;
            shape.X = pos.X;
            shape.Y = pos.Y + Length;

            lifespan = lifesp;
            TimeCompleted = -1;

            genes = new Dna(lifespan);
        }

        public Rocket(RndVector2D rndVector, int lifesp)
        {
            speed.X = rndVector.vec.X;
            speed.Y = rndVector.vec.Y;

            pos.X = 300;
            pos.Y = 300;
            Length = 20;
            shape.X = pos.X;
            shape.Y = pos.Y + Length;
            TimeCompleted = -1;

            lifespan = lifesp;

            genes = new Dna(lifespan);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, (float)pos.X, (float)pos.Y, (float)shape.X, (float)shape.Y);
        }

        public void Update(int count)
        {
            if (!Completed)
            {
                acc = Vector.Add(acc, 0.1 * genes.getCurrentGene(count));
                speed = Vector.Add(speed, acc);
                pos = Vector.Add(pos, speed);
                shape = Vector.Add(shape, speed);
                acc = Vector.Multiply(0, acc);

                double rot = Vector.AngleBetween(speed, shape);

                if (Math.Atan2(shape.Y, shape.X) < Math.Atan2(speed.Y, speed.X))
                {
                    //Rotate((int)rot);
                }
                else
                {
                    //Rotate(-(int)rot);
                }
            }

        }

        public double calcFitness(Target target)
        {
            double fitness = 1 / (Math.Sqrt(Math.Pow((pos.X - target.x), 2) + Math.Pow((pos.Y - target.y), 2)));
            if (Completed)
            {
                fitness = fitness * 10 + (100/TimeCompleted);
            }
            finalFitness = fitness;
            return fitness;
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
