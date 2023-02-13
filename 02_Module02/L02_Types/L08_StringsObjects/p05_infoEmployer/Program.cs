using System;
using System.Collections.Generic;
using System.Xml;

namespace p05_infoEmployer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var family = Console.ReadLine();
            var age = short.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            string egn = (Console.ReadLine());
            string empNum = (Console.ReadLine());
            Console.WriteLine("First name: " + name);
            Console.WriteLine("Last name: " + family);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + egn);
            Console.WriteLine("Unique Employee number: " + empNum);
        }
    }
}
