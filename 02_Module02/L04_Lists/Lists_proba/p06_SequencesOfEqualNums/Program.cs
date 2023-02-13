using System;
using System.Collections.Generic;
using System.Linq;

namespace p06_SequencesOfEqualNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            int bestStartIndex = 0;       
            int bestLength = 0;
            for (int i = 0; i < nums.Count -1; i++)
            {
                int tempStart = i;
                int tempLength = 0;
                while (nums[i] == nums[i + tempLength] && (i + tempLength)<nums.Count -1)
                {
                    tempLength++;
                }
                i += tempLength - 1;

                if (tempLength > bestLength)
                {
                    bestLength = tempLength;
                    bestStartIndex = tempStart;
                }
            }
            for (int i = 0 ; i < bestLength; i++)
            {
                Console.Write(nums[i + bestStartIndex] + " ");
            }
        }
    }
}
