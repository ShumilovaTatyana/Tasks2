// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        }
    }
return array;
}

void PrintMatrix(double[,] arr)
{
    for (double i = 0; i < arr.GetLength(0); i++)
    {
        for (double j = 0; j < arr.GetLength(1); j++)   
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write(arr[i, j] + ",");
            else Console.Write(arr[i, j] + "]");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreateMatrixRndInt(3, 4, 1, 20);
PrintMatrix(matrix);


// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100;
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }