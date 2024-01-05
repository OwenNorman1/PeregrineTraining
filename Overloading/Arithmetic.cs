using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Arithmetic
    {
        public int add(int a, int b)
        {
            Console.WriteLine("Adding int a and b");
            return a + b;
        }

        public double add(double a, double b)
        {
            Console.WriteLine("Adding double a and b");
            return a + b;
        }
    }
}
