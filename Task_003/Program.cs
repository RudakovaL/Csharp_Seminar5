// Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).

using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] transposedArray = Transpose(array);

        for (int i = 0; i < transposedArray.GetLength(0); i++)
        {
            for (int j = 0; j < transposedArray.GetLength(1); j++)
            {
                Console.Write(transposedArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] Transpose(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = array[i, j];
            }
        }

        return transposed;
    }
}