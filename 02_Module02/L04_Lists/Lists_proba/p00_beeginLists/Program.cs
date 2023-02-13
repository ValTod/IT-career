using System;
using System.Collections.Generic;
using System.Linq;

namespace p00_beeginLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[] { 3, 4, 1, 2, 6, 5 };
            numArr.Reverse();

            //List<int> numList = new List<int>();

            //for (int i = 0; i < numArr.Length; i++)
            //{
            //    numList.Add(numArr[i]);
            //}

            //List<int> numList = numArr.ToList();

            //string input = "3, 4, 1, 2,   6  ,   5 ";

            List<int> numList = Console.ReadLine()
                                  .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                  .Select(x=>int.Parse(x))
                                  .ToList();

            int num = numList[numList.Count - 1];   
            while (numList.Contains(num))
            {
                bool x = numList.Remove(num);
            }
            Console.WriteLine(String.Join(" ", numList));
        }
    }
}
