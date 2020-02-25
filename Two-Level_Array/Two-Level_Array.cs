using System;

namespace Two_Level_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 3;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(array[row, col]);
                }
                Console.WriteLine();
            }

            // Досуп до першого елемента першого рядка першого стовпчика
            int value1 = array[0, 0];

            // Досуп до першого елемента першого рядка другого стовпчика
            int value2 = array[0, 1];

            // Досуп до першого елемента дрyгого рядка першого стовпчика
            int value3 = array[1, 0];

            Console.WriteLine();
            Console.WriteLine("'Console.WriteLine()' shows:");
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            Console.WriteLine();
            Console.WriteLine("'Console.Write()' shows:");
            Console.Write(value1);
            Console.Write(value2);
            Console.Write(value3);
            Console.ReadLine();
        }
    }
}
