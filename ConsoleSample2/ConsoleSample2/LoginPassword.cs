using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample2
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 4.  Реализовать метод проверки логина и пароля. 
    /// На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    /// Используя метод проверки логина и пароля, написать программу: 
    /// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
    /// С помощью цикла do while ограничить ввод пароля тремя попытками.
    /// </summary>
    static class LoginPassword
    {
        /// <summary>
        /// Программа для проверки логина и пароля  (Логин: root, Password: GeekBrains).
        /// </summary>
        public static void EnterOutInf()
        {
            Console.WriteLine("Введите свой логин и пароль.\nВнимание! У Вас всего три попытки.");
           
            int isCount = 3;
            int count = 0;
            string Login;
            string Password;

            do
            {
                Console.WriteLine("Логин:");
                Login = Console.ReadLine();
                Console.WriteLine("Пароль:");
                Password = Console.ReadLine();

                if (Chek(Login, Password))
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль, проверьте регистр и раскладку клавиатуры.");
                    count++;
                    if (count == isCount)
                    {
                        Console.WriteLine("Попытки закончились, обратитесь в службу поддержки!"); 
                    }
                }
            }
            while (count < isCount);

            Console.ReadLine();
        }

        /// <summary>
        /// Метод, проверяющий на истинность логин и пароль
        /// </summary>
        /// <param name="login"> логин пользователя </param>
        /// <param name="password"> пароль пользователя</param>
        /// <returns></returns>
        static bool Chek(string login, string password)
        {
            string isLogin = "root";
            string isPassword = "GeekBrains";

            if (login != isLogin || password != isPassword)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}



