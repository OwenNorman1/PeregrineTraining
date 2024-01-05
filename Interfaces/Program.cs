﻿namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.height = a;
            rec.width = b;
            area=rec.Area();
            perimeter = rec.Perimeter();
            Console.WriteLine("Area of rectangle is : {0:F}", area);
            Console.WriteLine("Perimeter of rectangle is : {0:F}", perimeter);
            Console.WriteLine("Circle area and perimeter");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle is : {0:F}", area);
            perimeter = circle.Perimeter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);
            Console.ReadLine();
        }
    }
}
