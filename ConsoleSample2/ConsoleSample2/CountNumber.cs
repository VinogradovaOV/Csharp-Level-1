using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 2, посчитать колличество цифр в числе
    /// </summary>
    static class CountNumber
    {
        /// <summary>
        /// Метод для подсчета колличества цифр в числе.
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Программа подсчета колличества цифр в числе.");
            Console.WriteLine("Внимание, нули перед числом не учитываются!\n");
            Console.WriteLine("Введите число:");
            string str = Console.ReadLine();
            double num = Convert.ToDouble(str);
            int i = 0;
            while (num >= 1)
            {
                num /= 10;
                i++; 
            }
            Console.WriteLine("Цифр в числе " + i);
            Console.WriteLine("Символов в строке " + str.Length);
            Console.ReadLine();

        }
    }
}
