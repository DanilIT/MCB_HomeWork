using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            Console.WriteLine("Введите любые три значения");
            string[] stringArray = new string[3];
            stringArray[index++] = Console.ReadLine();
            stringArray[index++] = Console.ReadLine();
            stringArray[index] = Console.ReadLine();

            Console.WriteLine("{0} {1} {2}", stringArray[index--], stringArray[index--], stringArray[index]);

        }
    }
}
