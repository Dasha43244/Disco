
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Нажмите Enter для начала...");

        Console.ReadLine(); // Ожидаем нажатия Enter

        Console.Clear(); // Очищаем консоль

        Random random = new Random();

        while (true)
        {
            int row = random.Next(Console.WindowHeight); // Случайная строка
            int col = random.Next(Console.WindowWidth);  // Случайная колонка
            int number = random.Next(10); // Случайное число от 0 до 9

            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            ConsoleColor randomColor = colors[random.Next(colors.Length)]; // Случайный цвет

            Console.SetCursorPosition(col, row);
            Console.ForegroundColor = randomColor;
            Console.Write(number);

            Thread.Sleep(1); // Ждем 1 секунду перед следующей сменой цвета
        }
    }
}
//class Program
//{
//    static void Main()
//    {
//        Console.Clear(); // Очищаем консоль

//        while (true)
//        {
//            Console.WriteLine("   ****    ****");
//            Console.WriteLine("  ******  ******");
//            Console.WriteLine("******************");
//            Console.WriteLine("******************");
//            Console.WriteLine("******************");
//            Console.WriteLine(" ****************");
//            Console.WriteLine("  **************");
//            Console.WriteLine("   ************");
//            Console.WriteLine("    **********");
//            Console.WriteLine("      ******");
//            Console.WriteLine("        **");

//            // Устанавливаем случайный цвет для цифр
//            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
//            Random random = new Random();
//            ConsoleColor randomColor = colors[random.Next(colors.Length)];

//            // Меняем цвет цифр
//            Console.ForegroundColor = randomColor;

//            // Ждем некоторое время перед очередным выводом
//            Thread.Sleep(1000); // Подождем 1 секунду перед выводом сердечка
//            Console.Clear(); // Очищаем консоль перед следующим выводом
//        }
//    }
//}