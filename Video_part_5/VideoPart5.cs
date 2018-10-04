using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck johnDuck = new Duck("John", "Black", 2);
            johnDuck.Fly("tree");

            Duck bobDuck = new Duck("Bob", "Blue", 1);
            bobDuck.Fly("sky");
            Console.ReadLine();

        }
    }

    class Duck
    {
        public Duck(string name, string color, int life)
        {
            Name = name;
            Color = color;
            Life = life;
        }

        public string Color;
        public string Name;
        public int Life;

        public void Fly(string place)
        {
            Console.WriteLine("I am flying to " + place + "; Name: " + Name +"; Color: " + Color + "; Life: " + Life);
        }
    }
}
