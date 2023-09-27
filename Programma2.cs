using System;
class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("Выберите программу : ");
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UgadayChislo();
                    break;
                case 2:
                    TablitsaUmnojenia();
                    break;
                case 3:
                    Deliteli();
                    break;
                case 4:
                    Vihod();
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        } while (choice != 0);
    }
    static void UgadayChislo()
    {
        Random random = new Random();
        int chislo = random.Next(1, 101);
        int popytki = 0;
        int vvod = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать!");

        while (vvod != chislo)
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out vvod))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                continue;
            }

            popytki++;

            if (vvod < chislo)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (vvod > chislo)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine("Поздравляю! Вы угадали число!");
                Console.WriteLine("Количество попыток: " + popytki);
            }
        }

        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить.");
        Console.ReadKey();
    }
    static void TablitsaUmnojenia()
    {
        Console.WriteLine("Таблица умножения:\n");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0}\t", i * j);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
        Console.ReadKey();
    }
    static void Deliteli()
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Делители числа {0}: ", num);

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
        Console.ReadKey();
    }
    static void Vihod()
    {
        Console.WriteLine("Выход..");
        Environment.Exit(0);
    }
}
