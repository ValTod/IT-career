using System;

namespace p01_Hi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var family = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {name} {family}. You are {age} years old.");
        }
    }
}
