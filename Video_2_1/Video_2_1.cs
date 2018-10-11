using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            string s;
            Console.WriteLine("Задайте число 1, 2 чи 3");
            number = Console.ReadLine();

            // Operator switch
            switch (number)
            {
                case "1": s = "спорт"; break;
                case "2": s = "прогулянка"; break;
                case "4":
                case "3": {s = "програмування"; s += ", спорт";} break;
                default: s = "Не коректне введення данних"; break;
            }

            // Operator if
            /*
            if (number == "1")
                s = "спорт";
            else if (number == "2")
                s = "прогулянка";
            else if (number == "3")
                s = "програмування";
            else
            {
                s = "Не коректне введення данних";
                Console.WriteLine("else");
            }
            */

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
