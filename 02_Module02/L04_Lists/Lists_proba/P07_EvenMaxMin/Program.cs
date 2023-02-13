using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_EvenMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> list = input
                             .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                             .Select(x=>int.Parse(x))
                             .ToList();
            List<int> evenNums = new List<int>();
            int min = list[0]; // min = int.MaxValue;
            int max = list[0]; // max = int.MinValue;
            foreach (var item in list)
            {
                if (item < min)
                {
                    min = item;
                }
                if (item > max) 
                { 
                    max = item; 
                }
                if (item % 2 == 0)
                {
                    evenNums.Add(item); 
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"minValue = {min}\nmaxValue = {max}"); 

            List<int> maxMinValues= new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == min || list[i] == max)
                {
                    maxMinValues.Add(list[i]);
                }
                if (list[i] % 2 == 0)
                {
                    Console.Write(list[i] + " ");
                }   
            }
            Console.WriteLine();
            Console.WriteLine(" Sorted list with min and max values in the previous list:");
            maxMinValues.Sort();
            Console.WriteLine(String.Join("", maxMinValues));    
            Console.WriteLine();
            evenNums.Sort();
            evenNums.Reverse();
            evenNums.ForEach(num => Console.Write(num + " "));
            
        }
    }
}
