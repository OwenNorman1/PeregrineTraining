using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            Console.WriteLine("Enter First Number:");
            firstNumber=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First Number is bigger");
            } else if (firstNumber == secondNumber)
            {
                Console.WriteLine("The two numbers are equal");
            } else
            {
                Console.WriteLine("Second Number is bigger");
            }
            Console.ReadLine();
        }
    }
}
