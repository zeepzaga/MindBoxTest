using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Triangle : Figure
    {
        public double ASide { get; }
        public double BSide { get; }
        public double CSide { get; }

        /// <summary>
        /// Массив сторон для внутренних вычислений
        /// </summary>
        private readonly double[] _sides;

        /// <summary>
        /// Экземпляр фигуры треугольник
        /// </summary>
        /// <param name="a">Сторона а > 0</param>
        /// <param name="b">Сторона b > 0</param>
        /// <param name="c">Сторона c > 0</param>
        /// <exception cref="ArgumentException">Треугольник не существует, если сумма наименьших сторон меньше третьей</exception>
        public Triangle(double aSide, double bSide, double cSide)
        {
            _sides = new double[] { aSide, bSide, cSide };
            Array.Sort(_sides);
            if (_sides.Count(p => p < 0) > 0 || _sides[0] + _sides[1] < _sides[2])
                throw new ArgumentException("Треугольник с таким сторонами не может существовать");
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        /// <summary>
        /// Возвращает площадь треугольника по формуле герона
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            double halfPerimeter = _sides.Sum() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - ASide) * (halfPerimeter - BSide) * (halfPerimeter - CSide));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Вернёт true, если треугольник прямоугольный</returns>
        public bool IsTriangleRectangular()
        {
            return Math.Sqrt(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2)) == _sides[2];
        }
    }
}
