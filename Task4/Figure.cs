using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task4
{
    public class Figure
    {
        Point pointA;
        Point pointB;
        Point pointC;
        Point pointD;
        Point pointE;

        double abSide;
        double bcSide;
        double cdSide;
        double deSide;

        double caSide;
        double daSide;
        double eaSide;

        public Figure(Point A, Point B,Point C)
        {
            this.pointA = A;
            this.pointB = B;
            this.pointC = C;
            this.pointD = new Point("no_info", 0, 0);
            this.pointE = new Point("no_info", 0, 0);
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.pointA = A;
            this.pointB = B;
            this.pointC = C;
            this.pointD = D;
            this.pointE = new Point("no_info", 0, 0);
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.pointA = A;
            this.pointB = B;
            this.pointC = C;
            this.pointD = D;
            this.pointE = E;
        }

        public double SideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }
        public void PerimeterCalculator()
        {
            if (pointD.Str == "no_info")
            {
                abSide = SideLength(pointA, pointB);
                bcSide = SideLength(pointB, pointC);
                caSide = SideLength(pointC, pointA);
                Console.WriteLine("Triangle perimeter is " + (abSide + bcSide + caSide));
            }
            else
            {
                if (pointE.Str == "no_info")
                {
                    abSide = SideLength(pointA, pointB);
                    bcSide = SideLength(pointB, pointC);
                    cdSide = SideLength(pointC, pointD);
                    daSide = SideLength(pointD, pointA);
                    Console.WriteLine("Quadrangle perimeter is " + (abSide + bcSide + cdSide+daSide));
                }
                else
                {
                    abSide = SideLength(pointA, pointB);
                    bcSide = SideLength(pointB, pointC);
                    cdSide = SideLength(pointC, pointD);
                    deSide = SideLength(pointD, pointE);
                    eaSide = SideLength(pointE, pointA);
                    Console.WriteLine("Pentagon perimeter is " + (abSide + bcSide + cdSide + deSide+eaSide));
                }
            }
        }
    }
}