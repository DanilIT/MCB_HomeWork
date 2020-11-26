using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInWeek = 7;
            Console.WriteLine(daysInWeek);

            int weeksInYear = 52,18;
            Console.WriteLine(weeksInYear);

            int daysInYear = daysInWeek * weeksInYear;
            Console.WriteLine(daysInYear);
        }
    }
}
