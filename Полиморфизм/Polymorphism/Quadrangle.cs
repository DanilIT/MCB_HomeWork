﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Quadrangle : Polygon
    {
        public override string Name { get; set; } = "Четырехугольник";

        public override void DrawingMethod()
        {
            base.DrawingMethod();
            Console.WriteLine("Рисуем четырехугольник");
        }
    }
}
