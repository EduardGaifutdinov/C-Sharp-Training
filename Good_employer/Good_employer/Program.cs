using System;

namespace Good_employer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }
        
        private static string GetGreetingMessage(string name, double salary)
        {
            salary = Math.Ceiling(salary);  // Ceiling -> округляет в большую сторону
            
            return $"Hello, {name}, your salary is {salary}"; // с помощью {} и $ перед строкой, можно форматировать строку используя переменные
        }
    }
}