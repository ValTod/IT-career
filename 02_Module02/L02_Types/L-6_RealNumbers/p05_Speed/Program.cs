using System;

namespace p05_Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            float mS = m / (sec + min * 60.0f + hours * 60 * 60.0f);
            float kmH = m * 0.001f / (sec / 3600.0f  + min / 60.0f + hours);
            float mH = (m / 1609.0f) / (sec / 3600.0f + min / 60.0f + hours);
            Console.WriteLine($"{mS:f6}");
            Console.WriteLine($"{kmH:f6}");
            Console.WriteLine($"{mH:f6}");

        }
    }
}
