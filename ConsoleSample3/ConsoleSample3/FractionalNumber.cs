using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample3
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 3.Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    ///Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    ///Написать программу, демонстрирующую все разработанные элементы класса.
    ///Добавить проверку, чтобы знаменатель не равнялся 0.
    ///Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0")
    ///Добавить упрощение дробей.
    /// </summary>
    public class FractionalNumber
    {
        int m;
        int n;
        FractionalNumber y;

        /// <summary>
        /// Конструктор пустой дроби, нужен для внутренних вычислений
        /// </summary>
        private FractionalNumber()
        {
        }

        /// <summary>
        /// Конструктор дроби
        /// </summary>
        /// <param name="_m">Числитель</param>
        /// <param name="_n">Знаменатель</param>
        public FractionalNumber(int _m, int _n)
        {
            m = _m;
            n = _n <= 0 ? throw new ArgumentException("Знаменатель равен нулю") : _n;
        }


        /// <summary>
        /// Метод для сложения дробей
        /// </summary>
        /// <param name="x">2ое слагаемое</param>
        /// <returns>сумма</returns>
        public FractionalNumber Plus(FractionalNumber x)
        {
            y = new FractionalNumber();
            y.m = m * x.n + x.m * n;
            y.n = n * x.n == 0 ? throw new ArgumentException("Знаменатель равен нулю") : n * x.n;
            return y;
        }

        /// <summary>
        /// Метод для умножения дробей
        /// </summary>
        /// <param name="x">2ой множитель </param>
        /// <returns>произведение </returns>
        public FractionalNumber Mult(FractionalNumber x)
        {
            y = new FractionalNumber();
            y.m = m * x.m;
            y.n = n * x.n == 0 ? throw new ArgumentException("Знаменатель равен нулю") : n * x.n;
            return y;
        }

        /// <summary>
        /// Метод для вычитания дробей
        /// </summary>
        /// <param name="x">вычитаемое</param>
        /// <returns>разность</returns>
        public FractionalNumber Minus(FractionalNumber x)
        {
            y = new FractionalNumber();
            y.n = n * x.n == 0 ? throw new ArgumentException("Знаменатель равен нулю") : n * x.n;
            y.m = m * x.n - x.m * n;

            return y;
        }

        /// <summary>
        /// Метод для деления дробей
        /// </summary>
        /// <param name="x">знаменатель </param>
        /// <returns>результат деления</returns>
        public FractionalNumber Div(FractionalNumber x)
        {
            y = new FractionalNumber();
            y.m = m * x.n;
            y.n = n * x.m == 0 ? throw new ArgumentException("Знаменатель равен нулю") : n * x.m;
            return y;
        }

        /// <summary>
        /// метод для вывода на консоль
        /// </summary>
        /// <returns>форматированная строка</returns>
        public string Print()
        {
            int nod;
            if (m == 0) nod = 1; else nod = NOD(m, n);
            return m / nod + "/" + n / nod;
        }

        /// <summary>
        /// Вычисление наибольшего общего делителя дроби, для упрощения дробей
        /// </summary>
        /// <param name="a">числитель</param>
        /// <param name="b">знаменатель</param>
        /// <returns>нод</returns>
        int NOD(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b; else b = b - a;
            return a;
        }

        /// <summary>
        /// Пример использования методов для операций над дробями
        /// </summary>
        /// <param name="fnum">дробь</param>
        public void Example(FractionalNumber fnum)
        {
            Console.WriteLine("Пример использования методов для операций над дробями");
            Console.WriteLine("Первая дробь = " + this.Print());
            Console.WriteLine("Вторая дробь = " + fnum.Print());
            Console.WriteLine("Метод Plus - сложение = " + this.Plus(fnum).Print());
            Console.WriteLine("Метод Minus - вычитание = " + this.Minus(fnum).Print());
            Console.WriteLine("Метод Mult - умножение = " + this.Mult(fnum).Print());
            Console.WriteLine("Метод Div - деление = " + this.Div(fnum).Print());
            Console.ReadLine();
        }
    }

}
