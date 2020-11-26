using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInWeek = 7;
            Console.WriteLine(daysInWeek);

            int weeksInYear = 52;
            Console.WriteLine(weeksInYear);

            int daysInYear = daysInWeek * weeksInYear;
            Console.WriteLine(daysInYear);
        }
    }
}
