using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte counter = 0;
            for (int i = 0; i < 260; i++)
            {
                counter++;
                Console.WriteLine(counter);
            }

        }
    }
}
