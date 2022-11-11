using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle : Figure
    {
        public double Radius { get; }

        /// <summary>
        /// Экзампляр фигуры круг.
        /// </summary>
        /// <param name="radius">Радиус круга > 0</param>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть 0 или меньше");
            Radius = radius;
        }

        /// <summary>
        /// Площадь круга по формуле PI*radius^2
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
