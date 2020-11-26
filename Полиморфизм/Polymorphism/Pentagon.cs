using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Pentagon : Polygon
    {
        public override string Name { get; set; } = "Пятиугольник";

        public override void DrawingMethod()
        {
            base.DrawingMethod();
            Console.WriteLine("Рисуем пятиугольник");
        }
    }
}
