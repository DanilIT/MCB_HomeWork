using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomewWork
{
    class Schoolboy
    {
    }

    class Student : IDriver
    {
        public void Drive(string car)
        {
            throw new NotImplementedException();
        }

        public void FillUpTank(int litres)
        {
            throw new NotImplementedException();
        }
    }

    class Worker
    {

    }
}
