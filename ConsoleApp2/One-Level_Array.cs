using System;

namespace One_Level_Array
{
    class Program
    {
        public static int[] lotteryTickets = { 11, 3, 7, 1, 14, 21 };

        public static void Main()
        {
            ShowArray();
            Reverse();
            //Sort();
            //SortAndReverse();
            //Index();
            ForEach();
            Console.ReadLine();
        }

        public static void Sort()
        {
            Console.WriteLine("Array.Sort Method sorts the elements in a one-dimensional array");

            Array.Sort(lotteryTickets);
            for (int i = 0; i<lotteryTickets.Length; i++)
            {
            Console.WriteLine(lotteryTickets[i]);
            }

            Console.WriteLine();
        }

        public static void Reverse()
        {
            Console.WriteLine("Array.Reverse Method Reverses the order of the elements in a one-dimensional Array or in a portion of the Array");
            
            Array.Reverse(lotteryTickets);
            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }

            Console.WriteLine();
        }

        public static void SortAndReverse()
        {
            Console.WriteLine("Sort and Reverse");

            Array.Sort(lotteryTickets);
            Array.Reverse(lotteryTickets);
            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }

            Console.WriteLine();
        }

        public static void Index()
        {
            Console.WriteLine("Array.IndexOf Method searches for the specified object and returns the index of its first occurrence in a one-dimensional array or in a range of elements in the array");
            int index = Array.IndexOf(lotteryTickets, 1);
            Console.WriteLine("index = " + index);
            Console.WriteLine();
        }

        public static void ForEach()
        {
            Console.WriteLine("foreach");
            foreach (var ticket in lotteryTickets)
            {
                Console.WriteLine(ticket);
            }
            Console.WriteLine();
        }

        public static void ShowArray()
        {
            Console.WriteLine("Show Array");
            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }
            Console.WriteLine();
        }
    }
}
