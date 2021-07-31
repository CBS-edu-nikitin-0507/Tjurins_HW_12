using System;
using System.Runtime.CompilerServices;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,10);

            Console.Write("Perimeter of rectangle is ");
            Console.WriteLine(rect.Area);

            Console.Write("Area of rectangle is ");
            Console.WriteLine(rect.Perimeter);

            Console.ReadLine();
        }
    }
}
