using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine();

            Console.Write("Введіть число X: ");
            int x;
            if (!int.TryParse(Console.ReadLine(), out x) || x < 0)
            {
                Console.WriteLine("Помилка: X має бути цілим числом не менше 0.");
                return;
            }

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            for (int i = x; i < words.Length; i++)
            {
                if (result != "") result += " ";
                result += words[i];
            }

            Console.WriteLine("Результат: " + result);
            Console.ReadLine();
        }
    }
}
