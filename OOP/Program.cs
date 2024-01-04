namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = 3; 
            int y = 5;
            int sum = 0;
            sum = calc.add(x, y);
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
