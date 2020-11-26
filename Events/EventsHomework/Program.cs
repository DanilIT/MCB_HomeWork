using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("Васёк");

            ZooWorker worker = new ZooWorker();

            lion.IsHungry += worker.FeedLion;
            //lion.IsHungry += (lion) => Console.WriteLine("Лев {0} покормлен работником", lion.Name);   
            lion.Walk();
            
        }
    }
}
