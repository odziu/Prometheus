using System;

namespace Lab_3_1
{
    public class MatrixMult
    {
        //  Перемноження матриць

        public static void Main() => MultiplyMatrix();

        public static void MultiplyMatrix()
        {
            var a = new[,]
            {
                {5, 10, 13, -4, 10},
                {20, 2, 9, 9, -1},
                {5, 10, 4, 8, 14},
                {6, 1, 2, 6, 10},
                {95, 5, 10, 10, 2}
            };

            var b = new[,]
            {
                {5, 10, 8, -4, 62},
                {20, 2, 9, 9, -1},
                {5, 10, 1, 8, 1},
                {6, 1, 2, 6, -5},
                {95, 5, 1, 3, 2}
            };

            var res = new int[a.GetLength(0), a.GetLength(1)];


            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    int nextVal = 0;
                    for (int k = 0; k < a.GetLength(0); k++)
                    {
                        nextVal += a[i, k] * b[k, j];
                    }

                    res[i, j] = nextVal;
                    Console.Write("|{0}", res[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();

            }
            Console.ReadLine();
        }

        /*
        Перемноження матриць

        Напишіть програму, що перемножить дві матриці. Результат виведіть у форматі:
            |число|число|число|число|число|
            |число|число|число|число|число|
            |число|число|число|число|число|
            |число|число|число|число|число|
            |число|число|число|число|число|

            Наприклад для матриць 
        |2|1|
        |2|3|
        та
        |1|3|
        |2|1|
                результат буде:
                                |2*1 + 1*2|2*3 + 1*1|
                                |2*1 + 3*2|2*3 + 3*1|
                                                        і потрібно вивести:
                                                                             |4|7|
                                                                             |8|9|
        */


    }
}
