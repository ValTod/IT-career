using System;
using System.Collections.Generic;

namespace p03_SortLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>() { "Nakov", "Angel", "Ivan", "Atanas", "Boris" };
            names.Sort();     // Сортираме списъка в нарастващ ред
            Console.WriteLine(string.Join(", ", names)); // Angel, Atanas, Boris, Ivan, Nakov
            names.Reverse();// Обръщаме списъка, получава се намалящ ред
            Console.WriteLine(string.Join(", ", names)); // Nakov, Ivan, Boris, Atanas, Angel
        }
    }
}
