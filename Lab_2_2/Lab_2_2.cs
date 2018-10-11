using System;

namespace Lab_2_2
{
    class Program
    {
        static void Main()
        {
            //  1000 for (%2)
            //  Напишіть програму, яка виведе всі ПАРНІ цілі числа в діапазоні від 2(включно) до 998(включно) у спадному порядку(998 996...).
            //  Кожне число виведіть в новому рядку.

            for (int i = 998; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
