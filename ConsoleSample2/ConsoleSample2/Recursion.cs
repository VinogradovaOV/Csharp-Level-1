using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b
    /// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
    /// </summary>
    static class Recursion
    {
        /// <summary>
        /// Программа с рекурсивным методом для вывода чисел в диапазоне от a до b
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Вывод чисел в диапазоне от a до b\n");
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Последовательность чисел:");
            Recurs(a, b);

            double sum = 0;
            SumRecurs(a, b, sum);

            Console.ReadLine();
        }
        /// <summary>
        /// Метод для написания последовательности чисел от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Recurs(double a, double b)
        {
            if (a <= b)
            {
                Console.Write(a + " ");
                Recurs(a + 1, b);               
            }
            
        }
        /// <summary>
        /// Метод подсчета суммы чисел в диапазоне от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        static void SumRecurs(double a, double b, double sum)
        {
            if (a <= b)
            {
                sum = sum + a;
                SumRecurs(a + 1, b, sum);
            }
            else
            {
                Console.WriteLine("\nСумма чисел = " + sum);
            }
        }
    }
}
