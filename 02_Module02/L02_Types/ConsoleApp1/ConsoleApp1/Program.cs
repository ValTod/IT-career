using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0f, b = 0.33f, sum = 1.33;
            Console.WriteLine("a+b={0} sum={1} equal={2}",
                                a + b, sum, (a + b == sum));

            double one = 0;
            for (int i = 0; i < 10000; i++)
            {
                one += 0.0001;
            }
            Console.WriteLine(one);

            //double x = 0.0000001f;
            //    for (int i = 0; i < 99999; i++)
            //{
            //    x++;
            //}
            //var y = 1213m;
            //Console.WriteLine(x);


            //byte counter = 0;
            //for (int i = 0; i < 260; i++)
            //{
            //    counter++;
            //    Console.WriteLine(counter);
            //}

            //double x = 123.123;
            //Console.WriteLine(x);
            //int xInt = (int)x;
            //Console.WriteLine(xInt);
            //long xLong = (long)xInt;
            //double xDouble = 123f; 
            //Console.WriteLine(xDouble);
            //float fff = 123f + 123;
        }
    }
}
