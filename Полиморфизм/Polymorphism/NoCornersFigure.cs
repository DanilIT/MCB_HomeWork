using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class NoCornersFigure : Figure
    {
        

        public override string Name { get; set; } = "Фигура без углов";

        public override void DrawingMethod()
        {
            Console.WriteLine("Рисуем фигуру без углов");
        }

    }
}
