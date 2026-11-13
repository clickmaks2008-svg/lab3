using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ціле число: ");
            long n;
            if (!long.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Помилка: це не ціле число.");
                return;
            }

            bool negative = n < 0;
            if (negative) n = -n;

            long reversed = 0;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n = n / 10;
            }

            if (negative) reversed = -reversed;

            Console.WriteLine("Результат: " + reversed);
            Console.ReadLine();
        }
    }
}
