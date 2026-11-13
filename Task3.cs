using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        // Приймає і крапку, і кому: 2.5 або 2,5
        static double ReadNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string s = Console.ReadLine().Replace(',', '.');
                double value;
                if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out value) && value > 0)
                    return value;
                Console.WriteLine("Помилка: введіть додатне число.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Площу якої фігури порахувати?");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Прямокутник");
            Console.WriteLine("4. Трикутник");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();
            double area;

            switch (choice)
            {
                case "1":
                    double side = ReadNumber("Сторона: ");
                    area = side * side;
                    break;
                case "2":
                    double r = ReadNumber("Радіус: ");
                    area = Math.PI * r * r;
                    break;
                case "3":
                    double a = ReadNumber("Перша сторона: ");
                    double b = ReadNumber("Друга сторона: ");
                    area = a * b;
                    break;
                case "4":
                    double baseLen = ReadNumber("Основа: ");
                    double height = ReadNumber("Висота: ");
                    area = baseLen * height / 2;
                    break;
                default:
                    Console.WriteLine("Помилка: невірний вибір.");
                    Console.ReadLine();
                    return;
            }

            Console.WriteLine("Площа = " + area);
            Console.ReadLine();
        }
    }
}
