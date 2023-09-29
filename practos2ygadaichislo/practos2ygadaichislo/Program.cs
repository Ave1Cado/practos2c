using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Попробуйте угадать число от 0 до 100.");

        int attempts = 0;
        int guess;

        do
        {
            Console.Write("Введите вашу догадку: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess) || guess < 0 || guess > 100)
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 0 до 100.");
                continue;
            }

            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {randomNumber} за {attempts} попыток.");
            }
        } while (guess != randomNumber);

        Console.WriteLine("Игра окончена. Нажмите Enter, чтобы выйти.");
        Console.ReadLine();
    }
}