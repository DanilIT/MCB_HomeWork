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
            ATM lenin = new ATM("lenin st. 1А", 500, "Иванов Иван Иванович");
            lenin.Summary();
            lenin.EnrollMoney(700);
            lenin.WithdrawMoney(300);
            lenin.ChangeCurrency("доллары");
            lenin.Summary();
        }

        
    }

    
}
