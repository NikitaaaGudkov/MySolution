using System;

using MyLibrary;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure figure1 = new Triangle(3, 4, 5);
            Console.WriteLine(figure1.GetSquare());
            Console.WriteLine(((Triangle)figure1).IsRightTriangle());

            IFigure figure2 = new Circle(10);
            Console.WriteLine(figure2.GetSquare());
        }
    }
}
