using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class AreaOfShapes:AreaOfSquare
    { 
        public double rectangle(double a, double b)
        {
            return a * b;
        }

        public override double square(double a, double b)
        {
            Console.WriteLine("Area of the square a*b");
            return a * b;
        }
    }
}
