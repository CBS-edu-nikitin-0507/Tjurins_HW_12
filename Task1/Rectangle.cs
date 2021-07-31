using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle
    {
        private double Side1 { get; set; } 
        private double Side2 { get; set; }
        
        private double area;
        public double Area { get { return AreaCalculator(); } }

        private double perimeter;
        public double Perimeter { get { return PerimeterCalculator(); } }

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double AreaCalculator()
        {
            double result = Side1 * Side2;
            return result;
        }
        public double PerimeterCalculator()
        {
            double result = (Side1 + Side2) * 2;
            return result;
        }
    }
}
