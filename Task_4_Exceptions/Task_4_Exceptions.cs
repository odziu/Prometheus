using System;

namespace Task_4_Exceptions
{
    class Task_4_Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                PrintName(surname: "Petko");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void PrintName(string name = "Vasylii", string surname = "Kuchko", string middleName = "Petrovych")
        {
            if (surname == "Petko")
            {
                throw new Exception($"{surname} ne budem vyvodyty.");
            }
            Console.WriteLine($"{name} {surname} {middleName}");
        }
    }
}
