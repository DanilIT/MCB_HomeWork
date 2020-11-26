using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you need an antivirus checking?");

            string answer = Console.ReadLine();
            string lowerAnwer = answer.ToLower();
            switch (lowerAnwer)
            {
                case "да": 
                Console.WriteLine("Checking the system...");
                    break;

                default:
                    Console.WriteLine("Warning your computer may have viruses!");
                    break;
            }          
                       


            //IfElseConstructions();

            //CycleFor();

            //CycleForeach();

            //CycleWhile();

            //CycleDoWhile();

        }

        /// <summary>
        /// дз цикл for
        /// </summary>
        static void CycleFor()
        {
            string[] array = { "uno", "two", "три", "четыре", "ssss" };
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        /// <summary>
        /// дз цикл foreach
        /// </summary>
        static void CycleForeach()
        {
            int[] intArrray = { 1, 3, 4, 5, 7 };

            Array.Reverse(intArrray);
            foreach (int item in intArrray)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// дз цикл while
        /// </summary>
        static void CycleWhile()
        {
            int[] intArrray = { 1, 3, 4, 5, 0, 7 };

            int i = 0;
            while (intArrray[i] != 0)
            {
                Console.WriteLine(intArrray[i]);
                i++;
            }
        }

        static void CycleDoWhile()
        {
            do
            {
                Console.WriteLine("Greetins my friend!");
            } while (DateTime.Now.Year == 2000);
        }

        static void IfElseConstructions()
        {
            Console.WriteLine("Do you need an antivirus checking?");

            string answer = Console.ReadLine();
            string lowerAnwer = answer.ToLower();
            if (lowerAnwer == "yes" ^ lowerAnwer == "да")
                Console.WriteLine("Checking the system...");
            else
                Console.WriteLine("Warning your computer may have viruses!");
        }
    }
}
