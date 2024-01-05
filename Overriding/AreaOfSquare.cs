using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class AreaOfSquare
    {
        public virtual double square(double a, double b)
        {
            Console.WriteLine("Calculating the area of the sqaure a^b");
            return Math.Pow(a, 2);
        }
    }
}
