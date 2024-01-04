using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace FunctionBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int sum = 0;
            int squared = 0;
            sum = Add(a, b);
            squared = Square(a);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Square: {0}", squared);
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Square(int a)
        {
            return a * a;
        }
    }
}
