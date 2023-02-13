using System;

namespace p06_Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Heigth: ");
            double height = double.Parse(Console.ReadLine());
            double V = (len + width + height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
        }
    }
}
