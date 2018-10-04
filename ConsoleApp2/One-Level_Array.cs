using System;

namespace One_Level_Array
{
    class Program
    {
        public static int[] lotteryTickets = { 11, 3, 7, 1, 14, 21 };

        public static void Main()
        {
            //Sort();
            //Reverse();
            //SortAndReverse();
            //Index();
            //ForEach();
            ShowArray();
            Console.ReadLine();
        }

        public static void Sort()
        {
            Array.Sort(lotteryTickets);
            
            for (int i = 0; i<lotteryTickets.Length; i++)
            {
            Console.WriteLine(lotteryTickets[i]);
            }
        }

        public static void Reverse()
        {
            Array.Reverse(lotteryTickets);

            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }

        }

        public static void SortAndReverse()
        {
            Array.Sort(lotteryTickets);
            Array.Reverse(lotteryTickets);

            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }

        }

        public static void Index()
        {
            int index = Array.IndexOf(lotteryTickets, 1);
            Console.WriteLine("index = " + index);
        }

        public static void ForEach()
        {
            foreach (var ticket in lotteryTickets)
            {
                Console.WriteLine(ticket);
            }
            
        }

        public static void ShowArray()
        {
            for (int i = 0; i < lotteryTickets.Length; i++)
            {
                Console.WriteLine(lotteryTickets[i]);
            }
           
        }
    }
}
