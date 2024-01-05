namespace Overriding
{
    public class Program
    {
        static void Main(string[] args)
        {
            AreaOfShapes areaSquare = new AreaOfShapes();
            double a = 10;
            double b = 10;
            double area = 0.0;
            area=areaSquare.square(a, b);
            Console.WriteLine("area of sqaure {0}", area);
            Console.ReadLine();
        }
    }
}
