using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EventsHomework
{
    class Lion
    {
        public string Name { get; }
        public event Action<Lion> IsHungry;

        public Lion(string name)
        {
            Name = name;
        }
        public void Walk()
        {
            Console.WriteLine("Лев гуляет.");
            Thread.Sleep(3000);
            Console.WriteLine("лев голоден");
            if (IsHungry != null) 
                IsHungry(this);
        }
        //public void Walk(bool toLong)
        //{
        //    Console.WriteLine("Лев гуляет долго");
            
        //    if (IsHungry != null) 
        //        IsHungry();
        //}
    }
}
