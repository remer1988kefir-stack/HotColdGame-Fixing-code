bool repeat;
Random random = new Random();

do
{
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    int guess;

    Console.WriteLine("=================================");
    Console.WriteLine("      Игра Холодно / Горячо");
    Console.WriteLine("=================================");
    Console.WriteLine("Я загадал число от 1 до 100.");
    Console.WriteLine("Попробуй его угадать!");

    Console.WriteLine("Введите число:");

    bool success = int.TryParse(Console.ReadLine(), out guess);
    Console.WriteLine(secretNumber);
    while (!success || guess != secretNumber)
    {
        if (!success || guess < 1 || guess > 100)
        {
            Console.WriteLine("Введите допустимое число от 1 до 100");
            success = int.TryParse(Console.ReadLine(), out guess);
        }

        else
        {
            attempts += 1;

            int currentDistance = Math.Abs(secretNumber - guess);

            if (currentDistance <= 3)
            {
                Console.WriteLine("Очень горячо!");
            }
            else if (currentDistance <= 7)
            {
                Console.WriteLine("Горячо!");
            }
            else if (currentDistance <= 15)
            {
                Console.WriteLine("Тепло!");
            }
            else if (currentDistance <= 30)
            {
                Console.WriteLine("Холодно!");
            }
            else if (currentDistance <= 50)
            {
                Console.WriteLine("Холоднее!");
            }
            else
            {
                Console.WriteLine("Очень холодно!");
            }


            Console.WriteLine("Попробуй ещё:");
            success = int.TryParse(Console.ReadLine(), out guess);
        }
    }

    Console.WriteLine("Ты угадал!");
    Console.WriteLine($"Количество попыток: {attempts}");
    Console.WriteLine("Хотите сыграть ещё раз? (да/нет)");

    string input = Console.ReadLine().Trim().ToLower();

    repeat = input == "да" || input == "y";

} while (repeat);

Console.WriteLine("Программа завершена.");
