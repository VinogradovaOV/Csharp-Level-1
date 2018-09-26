using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{

    /// <summary>
    /// Виноградова О.В.
    /// Задание 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
    /// Хорошим называется число, которое делится на сумму своих цифр. 
    /// Реализовать подсчет времени выполнения программы, используя структуру DateTime.
    /// </summary>
    static class GoodNumber
    {
        /// <summary>
        /// Метод подсчета хороших чисел, в диапазоне от 1 до 100 000 000 считает около 30 сек. 
        /// </summary>
        public static void EnterOutInf(int length)
        {           
            int Count = 0;

            for (int i = 1; i <= length; i++)
            {                
                if (i % Rekursiv(i) == 0)
                {
                    //Console.WriteLine("Число, которое делится на сумму своих чисел = " + i);
                    Count++;
                }
            }

            Console.WriteLine("Колличество цифр делящихся на сумму своих чисел = " + Count);

            Console.ReadLine();

        }

        /// <summary>
        /// Рекурсивный метод, считающий сумму цифр
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int Rekursiv(int i)
        {
            if (i == 0)
                return 0;
            else
                return Rekursiv(i / 10) + i % 10;
        }


    }
}
