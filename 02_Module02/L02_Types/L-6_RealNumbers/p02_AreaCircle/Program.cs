using System;

namespace p02_AreaCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"{s:f12}");
        }
    }
}
