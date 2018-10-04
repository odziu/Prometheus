using System;

namespace Video
{
    class VideoPart4
    {
        static void Main(string[] args)
        {
            
            int i = 10;
            AddInt(ref i);
            Console.WriteLine(i);
            Console.WriteLine();
            
            
            int[,] a = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            Console.WriteLine("PrintArray(a)");
            PrintArray(a);

            Console.WriteLine();
            Console.WriteLine("PrintArray(a, ',')");
            PrintArray(a,',');

            var res = MulArray(a, 3);
            Console.WriteLine();
            Console.WriteLine("PrintArray(res) //res=a*3");
            PrintArray(res);
            
            Console.ReadLine();
        }

        static void AddInt(ref int i)
        {
            i++;
        }

        static int[,] MulArray(int[,] a, int mul)
        {
            int[,] res = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    res[i, j] = a[i, j] * mul;
                }
            }

            return res;
        }

        static void PrintArray(int[,] a, char separator = ' ')
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}{separator}");
                }
                Console.WriteLine();
            }
        }


    }
}
