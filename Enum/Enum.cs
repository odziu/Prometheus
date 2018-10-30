using System;

namespace Enum
{
    class Program
    {
        enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Day today = Day.Monday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            

            Month thisMonth = Month.Dec;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
            Console.WriteLine();

            Day favoriteDay = (Day)5;
            dayNumber = (int)favoriteDay;
            Console.WriteLine("{0} is favorite day. It`s number is #{1}.", favoriteDay, dayNumber);

            // Output:
            // Monday is day number #1.
            // Dec is month number #11.

            Console.ReadKey();
        }
    }
}
