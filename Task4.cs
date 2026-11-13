using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int pos = i + 1; // номер символу з 1

                if (pos % 15 == 0)
                    result += '?';
                else if (pos % 3 == 0)
                    result += 'X';
                else if (pos % 5 == 0)
                    result += '9';
                else
                    result += text[i];
            }

            Console.WriteLine("Результат: " + result);
            Console.ReadLine();
        }
    }
}
