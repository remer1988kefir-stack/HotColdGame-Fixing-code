using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

bool repeat;
Random random = new Random();
static string GetHint(int distance)
{
    if (distance <= 3)
        return "Очень горячо";
    else if (distance <= 7)
        return "Горячо";
    else if (distance <= 15)
        return "Тепло";
    else
        return "Холодно";
}
do
{
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    int guess;
    Console.WriteLine(secretNumber);
    static int GetValidNumber()
    {
        int number;
        bool success = int.TryParse(Console.ReadLine(), out number);
        while (!success || number < 1 || number > 100)
                {    
                        Console.WriteLine("Введите допустимое число от 1 до 100");
                        success = int.TryParse(Console.ReadLine(), out number);
                }
        return number;
    }

    Console.WriteLine("=================================");
    Console.WriteLine("      Игра Холодно / Горячо");
    Console.WriteLine("=================================");
    Console.WriteLine("Я загадал число от 1 до 100.");
    Console.WriteLine("Попробуй его угадать!");

    Console.WriteLine("Введите число:");
    guess = GetValidNumber();
    attempts += 1;

    while (guess != secretNumber)
    {
            int currentDistance = Math.Abs(secretNumber - guess);
            string hint = GetHint(currentDistance);
            Console.WriteLine(hint);
            
            

        Console.WriteLine("Попробуй ещё:");
        guess = GetValidNumber();
        attempts += 1;

    }
    Console.WriteLine("Ты угадал!");
    Console.WriteLine($"Количество попыток: {attempts}");
    Console.WriteLine("Хотите сыграть ещё раз? (да/нет)");

    string input = Console.ReadLine().Trim().ToLower();

    repeat = input == "да" || input == "y";

} while (repeat);

Console.WriteLine("Программа завершена.");
