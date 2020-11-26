using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Circle : NoCornersFigure
    {        
        public override string Name { get; set; } = "Круг";
                

        public override void DrawingMethod()
        {
            base.DrawingMethod();
            Console.WriteLine("Рисуем Круг");
        }
    }
}
