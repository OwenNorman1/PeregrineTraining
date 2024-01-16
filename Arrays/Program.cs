using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Working with arrays");
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.Count());
            numbers = numbers.Append<int>(10).ToArray();
            numbers = numbers.Append<int>(0).ToArray();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write(numbers[x] + ", ");
            }
            Console.Write("\nWorking with string arrays");
            string[] dayArray = new string[] { "Mon", "Tue" };
            dayArray = dayArray.Append("Wed").ToArray();
            foreach (var item in dayArray)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine("\nWorking with objects");
            object[] obj = new[] {"12","2.5","8","monday","tuesday"};
            double result;
            //1a.
            double sum = 0;
            foreach (var item in obj)
            {
                try
                {
                    result = Convert.ToDouble(item);
                    sum = sum + result;
                } catch (FormatException) {}
                Console.Write(item +" , ");
            }
            Console.WriteLine("\nSum of numbers = {0}", sum);
            //1b.
            Console.Write("Enter integers: ");
            String items = Console.ReadLine();
            int[] intlist = new int[items.Length];
            int sum2 = 0;
            for (int i = 0; i<items.Length; i++)
            {
                intlist[i] = (int)items[i]-48;
                sum2 = sum2 + intlist[i];
            }
            Console.WriteLine("Sum: {0}", sum2);
            //1c.
            Console.WriteLine("Enter a paldindrome: ");
            bool notpalin = false;
            String palindrome = Console.ReadLine();
            for (int i = 0; i<palindrome.Length/2; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length-i-1])
                {
                    notpalin = true;
                    break;
                }
            }
            if (notpalin)
            {
                Console.WriteLine("This is not a paldindrome");
            }
            else
            {
                Console.WriteLine("This is a palindrome");
            }
            //1d.
            int[] rev = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            for (int x = numbers.Length; x >= 0; x--)
            {
                Console.Write(rev[x] + ", ");
            }
            Console.ReadLine();
        }
    }
}
