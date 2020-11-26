using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
    class ZooWorker
    {
        public void FeedLion(Lion lion)
        {
            Console.WriteLine("Лев {0} покормлен работником", lion.Name);
            Console.WriteLine("Ом-ном-ном");
        }
    }
}
