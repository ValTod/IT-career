using System;

namespace p001_Reverce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", arr));
            for (int i = 0; i < arr.Length /2 ; i++)
            {
                int swap = arr[i];
                arr[i] = arr[arr.Length -1 - i];
                arr[arr.Length -1 - i] = swap;
            }
            Console.WriteLine();
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
