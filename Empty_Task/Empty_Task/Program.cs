using System;

namespace Empty_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("...12.321321.11."));
        }
        
        static string Decode(string text)
        {
            text = text.Replace(".", String.Empty); // Сначала удаляем все точки с помощью метода Replace

            var digit = int.Parse(text); // Создаём переменную в которую записываем числовое значение получение после обрезки точек

            while (digit >= 1024) // Обычный цикл, который будет начинать отсчет с 0 каждые 1203 чилса
            {
                digit -= 1024;
            }
            
            return digit.ToString(); // Теперь просто возвращаем значение в виде строки
        }
    }
}

// Задача требует написать функцию, которая будет "декодировать строку избавляя её от точек. Так же она имеет ограничение 1023, после этого числа отсчет начинается с начала" 