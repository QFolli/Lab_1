using System;

namespace Integral.Methods
{
    public static class _3_8
    {
        public static double Decision(double a, double b, double step, Program.FuncDelegate function)
        {
            double result = 0;

            var middle1 = function((2 * a + b) / 3);  // Первая треть фигуры
            var middle2 = function((a + 2 * b) / 3);  // Вторая треть фигуры

            for (var i = a; i < b; i += step)
            {
                var begin = function(i);  // Начало фигуры
                var end = function(i + step);  // Конец фигуры

                var stepResult = (begin + 3 * middle1 + 3 * middle2 + end) / 8 * step;  // Площадь фигуры
                result += stepResult;
            }

            return Math.Round(result, 4);
        }
    }
}