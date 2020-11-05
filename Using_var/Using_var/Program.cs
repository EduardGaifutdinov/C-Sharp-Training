using System;

namespace Using_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5.0; // ← исправленная строка. Компилятор не поймет сложение 5 и 0.5 
            a += 0.5;
            Console.WriteLine(a);
        }
    }
}