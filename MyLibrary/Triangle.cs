using System;

namespace MyLibrary
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public double GetSquare()
        {
            if(FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
            {
                return 0;
            }
            if(FirstSide >= SecondSide + ThirdSide ||
                SecondSide >= FirstSide + ThirdSide ||
                ThirdSide >= FirstSide + SecondSide)
            {
                return 0;
            }
            double halfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            double square = Math.Sqrt(halfMeter * (halfMeter - FirstSide) *
                (halfMeter - SecondSide) * (halfMeter - ThirdSide));
            return square;
        }

        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник - прямоугольный. Иначе - false.</returns>
        public bool IsRightTriangle()
        {
            double squareFirstSide = Math.Pow(FirstSide, 2);
            double squareSecondSide = Math.Pow(SecondSide, 2);
            double squareThirdSide = Math.Pow(ThirdSide, 2);
            return squareFirstSide == squareSecondSide + squareThirdSide
                || squareSecondSide == squareFirstSide + squareThirdSide
                || squareThirdSide == squareFirstSide + squareSecondSide;
        }
    }
}
