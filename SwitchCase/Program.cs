using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("Enter a positive number: ");
            x = Convert.ToInt16(Console.ReadLine());
            if (x >= 0)
            {
                switch (x)
                {
                    case 0:
                        Console.WriteLine("The value of a is zero");
                        break;
                    case 1:
                        Console.WriteLine("The value of a is one");
                        break;
                    case 2:
                        Console.WriteLine("The value of a is two");
                        break;
                    case 3:
                        Console.WriteLine("The value of a is three");
                        break;
                    case 4:
                        Console.WriteLine("The value of a is four");
                        break;
                    case 5:
                        Console.WriteLine("The value of a is five");
                        break;
                    default:
                        Console.WriteLine("The value is greater than five");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Negative numbers not allowed");
            }
            Console.ReadLine();
        }
    }
}
