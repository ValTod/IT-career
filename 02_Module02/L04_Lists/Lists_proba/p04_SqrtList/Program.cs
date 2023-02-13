using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_SqrtList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();
            var squares = new List<int>();
            foreach (var num in numList) 
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }
            squares.Sort();
            squares.Reverse();  
            squares.ForEach(x => Console.Write(x + " "));
        }
    }
}
