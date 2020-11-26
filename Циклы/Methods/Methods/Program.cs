using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
        public static int NumberOfCharsInString(string text)
        {             
            return text.Length; 
        }

        public static string PositiveOrNegativeNumber(int number)
        {            
            if (number > 0)
                return "Число больше нуля";
            if (number == 0)
                return "Число равно нулю";
            else 
                return "Число меньше нуля";
        }
    }
}
