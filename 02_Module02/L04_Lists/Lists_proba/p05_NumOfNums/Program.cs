using System;
using System.Drawing;
using System.Linq;

namespace p05_NumOfNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                             .Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            for (int i = 0; i < nums.Count; i++)
            {
                int num = nums[i];
                int broi = 0;   
                while ((i + broi) < nums.Count && nums[i + broi] == num)
                {
                    broi++;
                }
                Console.WriteLine($"{num} -> {broi}");
                i += broi-1;
            }
        }
    }
}
