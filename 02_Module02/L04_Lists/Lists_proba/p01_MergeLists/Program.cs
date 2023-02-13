using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_MergeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList(); // създаваме списък от списъци, разделени от '|'  
            List<int> result = new List<int>(); // създаваме празен списък за резултата                                               
            for (int index = lists.Count - 1; index >= 0; index--)// обождаме списъка от числовите списъци отзад напред:
            {
                List<string> nums = lists[index].Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();// отделяме списъка използвайки интервалите               
                for (int index2 = 0; index2 < nums.Count; index2++)
                {            // ако на nums[index2] има низ, който не е празен – обръщаме го в цяло число и го добавяме към result
                    result.Add(int.Parse(nums[index2].Trim()));
                }
            }
            Console.WriteLine(String.Join(" ", result));
            result.ForEach(x => Console.Write(x + " "));
        }
    }
}
