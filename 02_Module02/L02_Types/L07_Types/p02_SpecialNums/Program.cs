using System;

namespace p02_SpecialNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int j = i;
                while (j > 0)
                {
                    int x = j % 10;
                    sum+= x;
                    j /= 10;
                }
                if (sum == 5 || sum == 7 || sum ==11)
                {
                    Console.WriteLine($"{i}->True");
                }
                else Console.WriteLine($"{i}->False");
            }
            
        }
    }
}
