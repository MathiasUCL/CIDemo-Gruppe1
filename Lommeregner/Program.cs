
namespace Lommeregner
{
    public interface ICalculatoro
    {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
        double Power(double a, double b);
        double SquareRoot(double a);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }



}