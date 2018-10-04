using System;

namespace Task_4
{
    class Task_4_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//Простий метод");
            Method1("Variable");
            Console.WriteLine();

            Console.WriteLine("//Повертаєм значення");
            Console.WriteLine(Method2("Variable"));
            Console.WriteLine();

            Console.WriteLine("//Опцiональнi параметри");
            PrintName1("Petro");
            Console.WriteLine();

            Console.WriteLine("//Iменованi");
            PrintName2(surname: "Petko");
            Console.WriteLine();

            Console.WriteLine("//return");
            Method3("Variable");

            Console.ReadLine();
        }

        //Простий метод
        public static void Method1(string variable)
        {
            Console.WriteLine(variable);
        }

        //Повертаєм значення
        public static string Method2(string variable)
        {
            return variable + "10";
        }

        //Опціональні параметри
        static void PrintName1(string name = "Vasylii", string surname = "Kuchko")
        {
            Console.WriteLine($"{name} {surname}");
        }

        //Іменовані
        static void PrintName2(string name = "Vasylii", string surname = "Kuchko", string middleName = "Petrovych")
        {
            Console.WriteLine($"{name} {surname} {middleName}");
        }

        //return
        public static void Method3(string variable)
        {
            Console.WriteLine(variable);
            return;
        }

    }
}
