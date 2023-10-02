using System;

namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1.Игра Угадай число");
                Console.WriteLine("2.Таблица умножения");
                Console.WriteLine("3.Вывод делителей числа");
                Console.WriteLine("4.Выход");

                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:

                        Console.WriteLine("Угадайте число от 0 до 100:");
                        Random random = new Random();
                        int randomNumber = random.Next(0, 101);

                       

                        int userNumber;
                        do
                        {
                            Console.Write("Введите число: ");
                            userNumber = int.Parse(Console.ReadLine());

                            if (userNumber < randomNumber)
                            {
                                Console.WriteLine("Загаданное число больше.");
                            }
                            else if (userNumber > randomNumber)
                            {
                                Console.WriteLine("Загаданное число меньше.");
                            }
                            else
                            {
                                Console.WriteLine("Правильно");
                            }
                        }
                        while (userNumber != randomNumber);

                        Console.WriteLine("Обратно в меню");
                        break;
                    case 2:
                        int[,] multiplicationTable = new int[10, 10];
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                multiplicationTable[i, j] = (i + 1) * (j + 1);
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write($"{multiplicationTable[i, j],4}");
                            }

                        }   
                         Console.WriteLine();
                         break;
                    case 3:
                        Console.WriteLine("Введите число (для выхода введите 'выйти'):");
                        string input = Console.ReadLine();
                        if (input == "выйти")
                            break;

                        int number;
                        if (int.TryParse(input, out number))
                        {
                            Console.WriteLine("Делители числа " + number + ":");
                            for (int i = 1; i <= number; i++)
                            {
                                if (number % i == 0)
                                    Console.WriteLine(i);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат числа");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Программа завершена");
                        return;
                    default:
                        Console.WriteLine("Выберите число из списка");
                        break;

                }

            }
        }
    }
}
