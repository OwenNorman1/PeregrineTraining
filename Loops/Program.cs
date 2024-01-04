using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double count = 0;
            do
            {
                sum = sum + Math.Pow(count, 2);
                Console.WriteLine("count: {0}, sum: {1}", count, sum);
                count++;
            } while (count != 10);
                Console.ReadLine();
            for (int i = 0; i<100; i++)
            {
                if (i%2  == 0)
                {
                    continue;
                }
                Console.Write("{0}, ", i);
            }
            Console.ReadLine();
        }
    }
}
