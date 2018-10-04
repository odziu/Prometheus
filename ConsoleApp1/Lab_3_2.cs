using System;

namespace Lab_3_2
{
    public class SortProblem
    {
        public static void Main()
        {
            Sort();
            Console.ReadLine();
        }

        public static void Sort()
        {
            var a = new[]
            {
                10, 10, 5, 2, 2, 5, 6, 7, 8, 15, 4, 4, 4, 2, 3, 5, 5, 36, 32, 623, 7, 475, 7, 2, 2, 44, 5, 6, 7, 71, 2
            };

            int b = 0;
            int c = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                int max1 = i;
                for (int j = i + 1; j < a.Length; j++)
                    if (a[j] > a[max1])
                    {
                        max1 = j;
                    }

                Console.Write("{0}  ", max1); // вывод индексов массива
                b = a[max1];
                a[max1] = a[i];
                a[i] = b;
            }

            Console.WriteLine();

            for (int i = 0; i < a.Length; i++) // вывод самого измененного массива
            {

                Console.Write("{0}  ", a[i]);
            }
        }
    }
}
