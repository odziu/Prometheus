using System;

namespace Task_4_2
{
    class Tasl_4_2
    {
        //Завдання підвищенної складності
        static void Main(string[] args)
        {
            Console.Write(GetFullName(surname: "Petko"));
            Console.ReadLine();
        }

        static string GetFullName(string name = "Vasylii", string surname = "Kuchko", string middleName = "Petrovych")
        {
            try
            {
                return $"{name} {surname} {middleName}";
            }
            finally
            {
                Console.Write("Hm... ");
            }
        }
    }
}
