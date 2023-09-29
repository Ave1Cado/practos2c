using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите число (или 'q' для выхода): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                Console.WriteLine($"Делители числа {number}:");
                FindDivisors(number);
            }
            else
            {
                Console.WriteLine("Введите корректное число.");
            }
        }
    }

    static void FindDivisors(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}