using System;

namespace p03_symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(c);


            //            Console.WriteLine("кавичакта е \" искам да мина на нов ред \nTrimata musketari i d\'Artanqn \u2764 \u2765 \u2766");
            //            Console.WriteLine(@"C:\Windows\
            //       win.ini
            //osdafasjdkofjiosdaoji  wdoijfipawejdf : ldsfadfpkos");
            //for (int i = 65; i <= 122; i++)
            //{
            //    Console.WriteLine((char)(i) );

            //}
        }
    }
}
