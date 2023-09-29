using System;

class Program
{
    static void Main()
    {
        int size = 10; // Размер таблицы умножения (от 1 до 10)

        // Создаем матрицу для таблицы умножения
        int[,] multiplicationTable = new int[size, size];

        // Заполняем матрицу значениями таблицы умножения
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {
                multiplicationTable[i - 1, j - 1] = i * j;
            }
        }

        // Выводим матрицу в виде таблицы
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"{multiplicationTable[i, j],3} "); // Выравниваем значения
            }
            Console.WriteLine(); // Переход на следующую строку
        }
    }
}