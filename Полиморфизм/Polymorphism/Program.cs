using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] arr = {new Circle(), new Triangle(),
            new Quadrangle() };

            foreach(Figure figure in arr)
            {
                PrintInfo(figure);
            }
        }

        static void PrintInfo(Figure figure)
        {
            Console.WriteLine("Имя фигуры: {0}", figure.Name);
            figure.DrawingMethod();
            Console.WriteLine();
        }
    }
}
