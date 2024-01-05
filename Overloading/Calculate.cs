using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Calculate:Arithmetic
    {
        public float add(float a, float b)
        {
            Console.WriteLine("Adding float a and b");
            return a + b;
        }

        public String add(String a, String b)
        {
            Console.WriteLine("Adding String a and b");
            return "Hello" + a + b;
        }
    }
}
