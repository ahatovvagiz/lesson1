//Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
using System;

namespace lesson1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool error = false;
            if (int.TryParse(args[0], out int a) == false)
            {
                Console.WriteLine("Неверно задано значение A");
                error = true;
            }
            if (int.TryParse(args[2], out int b) == false)
            {
                Console.WriteLine("Неверно задано значение B");
                error = true;
            }
            if (error)
            {
                return;
            }
            switch (args[1])
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                default:
                    Console.WriteLine("Неизвестная арифметическая операция");
                    error = true;
                    break;
            }
        }
    }
}