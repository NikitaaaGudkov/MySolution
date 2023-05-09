using System;

namespace MyLibrary
{
    public class Circle : IFigure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double GetSquare()
        {
            if(Radius <= 0)
            {
                return 0;
            }
            double square = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(square, MidpointRounding.AwayFromZero);
        }
    }
}
