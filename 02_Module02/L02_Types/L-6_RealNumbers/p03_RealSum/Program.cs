using System;

namespace p03_RealSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal x = decimal.Parse(Console.ReadLine());  
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
