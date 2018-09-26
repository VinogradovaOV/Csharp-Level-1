using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задание 1, найти минимальное из трех чисел.
    /// </summary>
    static class Minimum
    {
        /// <summary>
        /// Программа для нахождения минимального из трех чисел.
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Программа находит минимальное из трех чисел.\n");
            Console.WriteLine("Введите первое число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Минимальное число = " + MinNumber(a, b, c));

            Console.ReadLine();

        }

        /// <summary>
        /// Метод для нахождения минимального из трех чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double MinNumber(double a, double b, double c)
        {
            if (a < b)
            {
                if (a < c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }

        }

    }

}

