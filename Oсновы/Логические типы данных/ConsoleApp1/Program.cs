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
            Console.WriteLine("Введите любое число:");
            string message = Console.ReadLine();
            int digit = int.Parse(message);
            Console.WriteLine("Ваше число больше нуля: {0}", digit > 0);
        }
    }
}
