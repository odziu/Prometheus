using System;

namespace Video_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // do while
            int i = 0;

            do
            {
                Console.WriteLine("Text");
                Console.WriteLine(i);
                i = i + 1;
            } while (i < 10);

            // while
            /*
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("Text");
                Console.WriteLine(i);
                i = i + 1;
            }
            */

            // for
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Text");
                Console.WriteLine(i);
            }
            */

            Console.ReadLine();
        }
    }
}
