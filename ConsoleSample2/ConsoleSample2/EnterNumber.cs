using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
    /// </summary>
    static class EnterNumber
    {
         /// <summary>
        /// Метод для подсчета всех нечетных положительных чисел в последовательности.
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Программа для подсчета всех нечетных положительных чисел в последовательности\n");
            double num;
            int sum = 0;
            do
            {
                Console.WriteLine("Введите любое число");
                num = Convert.ToDouble(Console.ReadLine());
                if (num % 2 != 0 && num > 0)
                {
                    sum++; 
                }
            }
            while (num != 0);

            Console.WriteLine("Сумма всех нечетных положительных чисел = " + sum);
            Console.ReadLine();
        }


    }
}
