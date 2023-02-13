using System;
using System.Collections.Generic;
using System.Linq;

namespace P00_VerryBegining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Peter");
            names.Add("Maria");
            names.Add("George");
            names.Add("Maria");
            names.Add("Maria");
            names.Add("Maria");
            names.Add("Maria");
            names.Sort();
            names.Reverse();
            foreach (var name in names)
            {
                Console.WriteLine(name);           
            }
            names.Remove("Maria");
            Console.WriteLine(String.Join(", ", names));
            while(names.Contains("Maria"))
            {
                Console.WriteLine(names.Contains("Maria"));
                names.Remove("Maria");
            }
            Console.WriteLine(names.Contains("Maria"));
            Console.WriteLine(String.Join(", ", names));
            names.Insert(1, "Maria");
            names.RemoveAt(0);  
            names.ForEach(x => Console.Write(x + " "));
            int counter = names.Count;
            var maxName = names.Max();
            Console.WriteLine(String.Join(';',maxName));
        }
    }
}
