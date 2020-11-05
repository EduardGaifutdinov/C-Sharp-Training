using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Methods_Wanted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
        }
        
        static string GetLastHalf(string text)
        {
            text = text.Remove(0, text.Length / 2); // удаляем половину строки с помощью методоа Remove. Первый аргумент - начало удаления, второй - конец удаления.
            var textMass = text.Split(' '); // Создаем массив из слов без пробелов
            return String.Concat(textMass); // С помощью метода Concat глобального класса String, соединяем массив, превращая его в строку.
        }
    }
}