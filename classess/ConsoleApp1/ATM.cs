using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATM
    {
        #region Конструкторы
        static string BankomatAddress { get; set; }
        public double Cash { get; set; }
        public string NameOfServant { get; set; }
        #endregion

        static string currency = "руб.";

        public ATM(string bankomatAddress, int cash, string nameOfServant)
        {
            BankomatAddress = bankomatAddress;
            Cash = cash;
            NameOfServant = nameOfServant;
        }

        #region Методы
        public void WithdrawMoney(int moneyAmount)
        {
            Console.WriteLine("Бззз... Бззз...");
            Console.WriteLine("Выдача {0} {1}", moneyAmount, currency);            
            Cash -= moneyAmount;
            Console.WriteLine("остаток на счете {0}{1}", Cash, currency);
        }

        public void EnrollMoney(int moneyAmount)
        {
            Console.WriteLine("Выдача {0} {1}", moneyAmount, currency);
            Cash += moneyAmount;
            Console.WriteLine("остаток на счете {0}{1}", Cash, currency);
             
        }
        /// <summary>
        /// конвертация валюты
        /// </summary>
        /// <param name="cur"></param>
        public void ChangeCurrency(string cur)
        {
            if (currency== "руб.")
            {
                if (cur == "рубли")                                   
                    Console.WriteLine("Валюта рубли");
                
                if (cur == "доллары")
                {
                    Cash = Cash / 80;
                    Console.WriteLine("Валюта изменена на доллары");
                    currency = "$";
                }
                else
                    Console.WriteLine("Неверный выбор валюты!");
            }
            else if (currency == "$")
            {
                if (cur == "доллары")
                    Console.WriteLine("Валюта доллары");

                if (cur == "рубли")
                {
                    Cash = Cash * 80;
                    Console.WriteLine("Валюта изменена на рубли");
                    currency = "руб.";
                }
                else
                    Console.WriteLine("Неверный выбор валюты!");
            }
           
        }

        public void Summary()
        {
            Console.WriteLine("Адрес банкомата: {0}, остаток на счете:  {1}{2}" +
                " Обслужиавет:  {3}", BankomatAddress, Cash, currency, NameOfServant);
        }

        #endregion
    }
}
