using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample3
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 2. С клавиатуры вводятся числа, пока не будет введен 0. 
    /// Подсчитать сумму всех нечетных положительных чисел.
    /// Сами числа и сумму вывести на экран, используя tryParse;
    /// </summary>
    static class EnterNumber
    {
        /// <summary>
        /// Метод для подсчета всех нечетных положительных чисел в последовательности.
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Программа для подсчета всех нечетных положительных чисел в последовательности\n");
            Console.WriteLine("Введите любые числа");
            double num;
            int sum = 0;

            do
            {
                if (double.TryParse(Console.ReadLine(), out num))
                {
                    if (OddPositive(num))
                        sum++;
                }
                else
                {
                    Console.WriteLine("Введите число!");
                    num = 1; //сделано для того, чтобы цикл не прерывался.
                }
            }
            while (num != 0);

            Console.WriteLine("Сумма всех нечетных положительных чисел = " + sum);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод выявления нечетного положительного числа
        /// </summary>
        /// <param name="num">число</param>
        /// <returns>истина, если число нечетное и положительное</returns>
        static bool OddPositive(double num)
        {
            return (num % 2 != 0 && num > 0);
        }

    }
}
