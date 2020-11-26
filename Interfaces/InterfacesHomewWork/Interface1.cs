using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomewWork
{
    public interface IDriver
    {
        void Drive(string car);
        void FillUpTank(int litres);
    }
}
