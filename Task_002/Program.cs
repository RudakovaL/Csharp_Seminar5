// Задайте двумерный массив целых чисел. Напишите программу, которая
// находит сумму элементов в каждом столбце массива и выводит её.

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);
        int[] columnSums = new int[columnCount];

        for (int j = 0; j < columnCount; j++)
        {
            for (int i = 0; i < rowCount; i++)
            {
                columnSums[j] += array[i, j];
            }
        }

        Console.WriteLine("Суммы элементов в каждом столбце:");
        for (int j = 0; j < columnCount; j++)
        {
            Console.WriteLine($"Столбец {j + 1}: {columnSums[j]}");
        }
    }
}