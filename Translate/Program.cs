using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            toDecimal();
            toDouble();
            Hours();
        }

        static void toDecimal() {
            int result = 0;
            int number;
            string input;

            Console.WriteLine("Введите двоичное число: ");
            input = Console.ReadLine();

            number = int.Parse(input);

            result += (number / 10000000) * 128;
            result += (number / 1000000 % 10) * 64;
            result += (number / 100000 % 10) * 32;
            result += (number / 10000 % 10) * 16;
            result += (number / 1000 % 10) * 8;
            result += (number / 100 % 10) * 4;
            result += (number / 10 % 10) * 2;
            result += (number / 1 % 10) * 1;

            Console.WriteLine("Десятичное число: " + result);
        }

        static void toDouble() {
            int result = 0;
            int number;
            string input;

            Console.WriteLine("Введите число: ");
            input = Console.ReadLine();

            number = int.Parse(input);

            // Преобразование в двоичную систему (для чисел от 0 до 255)
            result += (number / 128) % 2 * 10000000;
            result += (number / 64) % 2 * 1000000;
            result += (number / 32) % 2 * 100000;
            result += (number / 16) % 2 * 10000;
            result += (number / 8) % 2 * 1000;
            result += (number / 4) % 2 * 100;
            result += (number / 2) % 2 * 10;
            result += (number / 1) % 2 * 1;

            Console.WriteLine(result);
        }
        static void Hours() {
            Console.WriteLine("Введите часы: ");
            string input = Console.ReadLine();
            int hours = int.Parse(input);
            Console.WriteLine("Введите минуты: ");
            input = Console.ReadLine();
            int minutes = int.Parse(input);
            Console.WriteLine("Введите время: ");
            input = Console.ReadLine();
            int time = int.Parse(input);
            minutes += time;
            hours += minutes / 60;
            minutes -= (minutes / 60) * 60;
            Console.Write(hours);
            Console.Write(':');
            Console.Write(minutes);
            Console.ReadKey();
        }
    }
}