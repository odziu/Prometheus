using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple if
            int a = 10,
                b = a / 5;

            if (b <= 2)
            {
                Console.WriteLine("Менше або дорiвнює двом");
            }
            else if (b == 2)
            {
                Console.WriteLine("Дорiвнює двом");
            }

            Console.WriteLine();

            // do while
            int sum = 0;
            int i = 0;
            do
            {
                sum += i;
                i++;
            } while (i < 4);

            System.Console.WriteLine(sum);
            System.Console.WriteLine(i);

            Console.WriteLine();


            // привiт
            string name = "Марк";
            if (name == "марк")
            {
                Console.WriteLine("Привiт, Марк.");
            }
            else
            {
                Console.WriteLine("Привiт, Незнайомець.");
            }

            Console.ReadLine();


            /*
            Кіт чи Котик
            
            string a = "котик";

            switch (a)
            {
                case "котик":
                    Console.WriteLine(a);
                default:
                    Console.WriteLine(a);
            }
            */
        }
    }
}
