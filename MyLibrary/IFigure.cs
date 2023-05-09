namespace MyLibrary
{
    public interface IFigure
    {
        /// <summary>
        /// Вычисление площади фигуры.
        /// </summary>
        /// <returns>Положительное число, если у данной фигуры корректные параметры. Иначе - 0.</returns>
        double GetSquare();
    }
}
