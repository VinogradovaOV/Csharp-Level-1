using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 5.  а) Написать программу, которая запрашивает массу и рост человека, 
    /// вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    /// </summary>
    static class IndexMass
    {
        /// <summary>
        /// Метод для рассчета индекса массы тела, и вывода информации на основе индекса.
        /// </summary>
        public static void EnterOutInf()
        {
            double Stature; // = h, рост в метрах
            double Weight; // = m, масса тела кг
            double imt;

            Console.WriteLine("Введите рост в м:");
            Stature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес в кг:");
            Weight = Convert.ToDouble(Console.ReadLine());
            imt = Weight / (Stature * Stature);
            Console.WriteLine("Ваш индекс массы тела равен: {0:#.##}", Weight / (Stature * Stature));

            if (imt >= 18.5 && imt <= 25)
            {
                Console.WriteLine("Поздравляем! Ваш Вес в норме!");
            }
            else if (imt > 25)
            {
                Console.WriteLine("Вам нужно похудеть!");
                Console.WriteLine("Вам нужно похудеть  на {0:#.##} кг", (imt * (Stature * Stature) - 25 * (Stature * Stature)));
            }
            else if (imt < 18.5)
            {
                Console.WriteLine("Вам нужно набрать вес!");
                Console.WriteLine("Вам нужно набрать {0:#.##} кг", (18.5 * (Stature * Stature) - imt * (Stature * Stature)));
            }

            Console.ReadLine();
        }

    }
}
