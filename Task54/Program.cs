// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
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

int[,] matrix = CreateMatrixRndInt(num1, num2, minElem, maxElem);
PrintMatrix(matrix);

int[,] resMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

void SelectionSort(int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resMatrix.GetLength(1) - j - 1; k++)
            {
                if (resMatrix[i, k] > resMatrix[i, k + 1])
                {
                    int temp = resMatrix[i, k];
                    resMatrix[i, k] = resMatrix[i, k + 1];
                    resMatrix[i, k + 1] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
PrintMatrix(resMatrix);

// void PrintMatrix(int[,] arr)
// {
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     console.Write(arr[i, j] + " ");
//     Console.WriteLine();
// }
// return 0;
// }

// int[,] matrix = CreateMatrixRndInt(num1, num2, minElem, maxElem);
// PrintMatrix(matrix);
// Console.WriteLine();
//SelectionSort(array);
