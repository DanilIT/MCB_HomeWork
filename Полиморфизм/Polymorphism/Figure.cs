using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Figure
    {
        public abstract string Name { get; set; }             

        public abstract void DrawingMethod();
    }
}
