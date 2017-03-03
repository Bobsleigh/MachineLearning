using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MachineLearning
{
    public class RndVector2D
    {
        Vector vector;

        public RndVector2D()
        {
            vector = new Vector(1, 0);
            vector = RotatePoint(vector, new Vector(0, 0), RandomGen.rnd.Next(1, 361));
        }


        public Vector vec
        {
            get
            {
                return vector;
            }
            set
            {
                vector = value;
            }
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
