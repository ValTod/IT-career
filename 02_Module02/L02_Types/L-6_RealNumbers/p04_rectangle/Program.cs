using System;

namespace p04_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = 2 * a + 2 * b;
            double s = a * b;
            double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine($"{d:f13}");
        }
    }
}
