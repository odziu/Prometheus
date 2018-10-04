using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    class Task_5_2
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                new CreationCaunter();
            }
            Console.WriteLine(CreationCaunter._created);
            Console.ReadLine();
        }
    }

    public class CreationCaunter
    {
        public static int _created;

        public CreationCaunter()
        {
            _created++;
        }
    }
}
