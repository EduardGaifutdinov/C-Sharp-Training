using System;

namespace Typos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); // Фигурные скобки + апострафы
            var number = 5.5; // Запятая для разделение целого и вещественного недопустима. Ошибка в имени переменной
            number += 7; 
            Console.WriteLine(number); // Ошибка в имени метода, пропущен кэмелКейс
        }
    }
}