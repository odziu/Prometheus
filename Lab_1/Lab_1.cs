﻿using System;

namespace Lab_1
{
    //  У цьому завданні необхідно написати програму, що оголосить дві змінні:
    //  перша змінна - змінна цілочисельного(int) типу зі значенням 99,
    //  друга змінна - змінна дійсного(double) типу зі значенням 0.3525.
    //  Перемножте ці дві змінні та результат виконання призначте двом новим змінним: цілочисельного та дійсного типу.
    //  Виведіть ці дві останні змінні окремо в новому рядку в такому порядку: цілочисельна змінна, дійсна змінна
    //  (кожне значення повинне бути написане в новому рядку без розділових знаків).

    public class Test
    {
        static void Main()
        {
            int Var1 = 99;
            double Var2 = 0.3525;
            double Result1 = Var1 * Var2;
            int Result2 = Convert.ToInt32(Result1);
            Console.WriteLine(Result2);
            Console.WriteLine(Result1);
            Console.ReadLine();
        }
    }
}
