﻿// Задача 46. Задайте двумерный массив m и n, заполненный случайными числами.
// m = 3, n = 4

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m,  n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next (min, max + 1);
        }
    }
return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)   
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4, 10, 100);
PrintMatrix(matrix);