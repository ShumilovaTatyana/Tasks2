﻿//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с интексами (0,0); (1,1)

Console.WriteLine("Введите количетсво строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин элемент: ");
int minElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите макс элемент: ");
int maxElem = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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

int FindSumMainDiag(int[,] arr)
{
    int res = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
       {
            if (i == j) res += arr[i, j];
        }
    }
    return res;
}

int[,] matrix = CreateMatrixRndInt(num1, num2, minElem, maxElem);
PrintMatrix(matrix);
Console.WriteLine();
int sum = FindSumMainDiag(matrix);
Console.WriteLine(sum);