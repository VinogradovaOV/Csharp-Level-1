using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample3
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    /// Продемонстрировать работу структуры
    /// </summary>
    static class StructComplex
    {
        /// <summary>
        /// Структура Complex
        /// </summary>
       public struct Complex
        {
            public double im;
            public double re;

           /// <summary>
           /// Метод для сложения комплексных чисел
           /// </summary>
           /// <param name="x">2ое слагаемое</param>
           /// <returns>сумма</returns>
            public Complex Plus(Complex x)
            {
                Complex y;
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }

           /// <summary>
           /// Метод для умножения комплексных чисел
           /// </summary>
           /// <param name="x">2ой множитель </param>
           /// <returns>произведение </returns>
            public Complex Mult(Complex x)
            {
                Complex y;
                y.re = re * x.re - im * x.im;
                y.im = im * x.re + re * x.im;
                return y;
            }

           /// <summary>
           /// Метод для вычитания комплексных чисел
           /// </summary>
           /// <param name="x">вычитаемое</param>
           /// <returns>разность</returns>
            public Complex Minus(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }

           /// <summary>
           /// метод для вывода на консоль
           /// </summary>
           /// <returns></returns>
            public string Print()            
            {
                return re + " + " + im + "i";
            }
        }

        /// <summary>
        /// Метод для демонстрации работы структуры Complex
        /// </summary>
       public static void EnterOutInf()
       {
           Complex complex1;
           complex1.re = 10;
           complex1.im = 11;
           Complex complex2;
           complex2.re = 1;
           complex2.im = -10;

           Console.WriteLine("Структура Complex");
           Console.WriteLine("Первое комплексное число: " + complex1.Print());
           Console.WriteLine("Второе комплексное число: " + complex2.Print());
           Console.WriteLine("Сумма : " + complex1.Plus(complex2).Print());
           Console.WriteLine("Произведение: " + complex1.Mult(complex2).Print());
           Console.WriteLine("Разность: " + complex1.Minus(complex2).Print());

           Console.ReadLine();
       }

    }
}
