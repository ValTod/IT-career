using System;
using System.Linq;

namespace p01_stat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] stringArr = input.Split(' ');

            int[] intArr= new int[stringArr.Length];   
            int sum = 0;
            int min = int.MaxValue; 
            int max = int.MinValue;
            for (int i = 0; i < stringArr.Length; i++)
            {
                int x = int.Parse(stringArr[i]);
                intArr[i] = x;  
                sum += x;
                if (x < min)
                {
                    min = x;
                }
                if (x > max)
                {
                    max = x;
                }
            }
            double aaa = (double)sum / intArr.Length; //1.0 *sum / intArr.Length;
            //Console.WriteLine("aver = " + aaa);
            double aver = intArr.Average();
            //Console.WriteLine("aver = " + aver);
            Console.WriteLine($"Min = {min}\nMax = {max}\nSum = {sum}\nAverage = {aver}\n");



            //int[] arr = inArr.Select(int.Parse).ToArray();
            //int[] newArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
