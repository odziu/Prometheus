using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Task5
    {
        static void Main(string[] args)
        {
            var menu = new Menu(10);
            menu["0"] = "Pizza";
            Console.WriteLine(menu["0"]);
            Console.ReadLine();
        }
    }

    public struct Menu
    {
        private string[] beverages;

        public Menu(int length)
        {
            beverages = new string[length];
        }

        public string this[string stringIndex]
        {
            get { return this.beverages[int.Parse(stringIndex)]; }
            set { this.beverages[int.Parse(stringIndex)] = value; }
        }
    }
}
