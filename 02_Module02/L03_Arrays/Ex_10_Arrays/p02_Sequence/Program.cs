using System;

namespace p02_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] stringArr = input.Split(' ');
            int[] intArr = new int[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                intArr[i] = int.Parse(stringArr[i]);          
            }

            int index = 0;
            int br = 0;
            for (int i = 0; i < intArr.Length - 1; i++)
            {
               int x = intArr[i];
               int brTemp = 0;

                for (int j = 0; j < intArr.Length; j++)
                {
                    if (x == intArr[j])
                    {
                        brTemp++;
                        if (brTemp > br)
                        {
                            br = brTemp;
                            index = i;
                        }
                    }
                }
            }
            Console.WriteLine(intArr[index]);
        }
    }
}

               //while (intArr[i + 1] == x && i <=intArr.Length -1) 
               //{ 
               //     brTemp++;
               //     if (brTemp > br)
               //     {
               //         index = i;
               //         br = brTemp;
               //     }
               //     i++;
               //}