using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Circle
    {
        private double radius;
        private static int numOfCircles;


        public Circle(double radius)
        {
            this.radius = radius;
            numOfCircles++;
        }

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public double getCircumference()
        {
            return Math.PI * (2 * radius);
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static int getObjectCount()
        {
            return numOfCircles;
        }

        public static string formatNumber(double input)
        {
            return input.ToString("#.##");
        }
    }
}
