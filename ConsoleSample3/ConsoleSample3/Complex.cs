using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample3
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 1. б) Дописать класс Complex, добавив методы вычитания и произведения чисел. 
    /// Проверить работу класса
    /// </summary>
    class Complex
    {
        double re;
        double im;
        Complex y;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Complex()
        {
            re = 0;
            im = 0;
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="_re">действительная часть</param>
        /// <param name="_im">мнимая часть</param>
        public Complex(double _re, double _im)
        {
            re = _re;
            im = _im;
        }

        /// <summary>
        /// Метод для сложения комплексных чисел
        /// </summary>
        /// <param name="x">2ое слагаемое</param>
        /// <returns>сумма</returns>
        public Complex Plus(Complex x)
        {
            y = new Complex();
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
            y = new Complex();
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
            y = new Complex();
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

        /// <summary>
        ///  Метод демонстрирующий работу класса Complex
        /// </summary>
        /// <param name="_complex1">Первое комплексное число</param>
        /// <param name="_complex2">Второе комплексное число</param>
        public void OperationForComplex(Complex _complex1, Complex _complex2)
        {
            Console.WriteLine("Класс Complex");
            Console.WriteLine("Первое комплексное число: " + _complex1.Print());
            Console.WriteLine("Второе комплексное число: " + _complex2.Print());
            Console.WriteLine("Сумма : " + _complex1.Plus(_complex2).Print());
            Console.WriteLine("Произведение: " + _complex1.Mult(_complex2).Print());
            Console.WriteLine("Разность: " + _complex1.Minus(_complex2).Print());

            Console.ReadLine();
        }

    }
}
