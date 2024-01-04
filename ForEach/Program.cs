using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 4, 6, 8, 10 };
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
