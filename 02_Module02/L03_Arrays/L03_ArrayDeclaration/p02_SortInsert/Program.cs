using System;

namespace p02_SortInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, -2, 7, -3, -4, 10, 2 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }
        }
    }
}
