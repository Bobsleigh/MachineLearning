﻿using System;
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
        Vector endPoint = new Vector(0, 0);
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

        public Vector Shape
        {
            get
            {
                return shape;
            }
            set
            {
                shape.X = value.X;
                shape.Y = value.Y;

                endPoint.X = pos.X + shape.X;
                endPoint.Y = pos.Y + shape.Y;
            }
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

        public Vector EndPoint
        {
            get
            {
                return endPoint;
            }
            set
            {
                endPoint = value;
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
                Vector temp = RotatePoint(endPoint, pos, value - angle);
                Shape = Vector.Subtract(temp, pos);
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
            endPoint.X = pos.X;
            endPoint.Y = pos.Y + Length;
            shape.X = endPoint.X - pos.X;
            shape.Y = endPoint.Y - pos.Y;

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
            endPoint.X = pos.X;
            endPoint.Y = pos.Y + Length;
            Shape = Vector.Subtract(endPoint, pos);

            TimeCompleted = -1;

            lifespan = lifesp;

            genes = new Dna(lifespan);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, (float)pos.X, (float)pos.Y, (float)endPoint.X, (float)endPoint.Y);
        }

        public void Update(int count)
        {
            if (!Completed)
            {

                acc = Vector.Add(acc, 0.1 * genes.getCurrentGene(count));
                speed = Vector.Add(speed, acc);
                pos = Vector.Add(pos, speed);
                endPoint = Vector.Add(endPoint, speed);
                acc = Vector.Multiply(0, acc);

                double angleShape = (Math.Atan2(Shape.Y, Shape.X) * 180) / Math.PI;
                double angleSpeed = (Math.Atan2(speed.Y, speed.X) * 180) / Math.PI;

                Rotate(angleSpeed - angleShape);
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