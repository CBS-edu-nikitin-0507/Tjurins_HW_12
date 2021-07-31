using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point pointA = new Point("A", 1, 1);
            Point pointB = new Point("B", 5, 5);
            Point pointC = new Point("C", 10, 10);
            Figure fig = new Figure(pointA,pointB,pointC);

            Point pointD = new Point("D", 15, 15);
            Figure fig1 = new Figure(pointA, pointB, pointC, pointD);

            Point pointE = new Point("E", 20, 20);
            Figure fig2 = new Figure(pointA, pointB, pointC, pointD,pointE);

            //Console.WriteLine("AB length = "+fig.SideLength(pointA, pointB));
            fig.PerimeterCalculator();
            fig1.PerimeterCalculator();
            fig2.PerimeterCalculator();
        }
    }
}
