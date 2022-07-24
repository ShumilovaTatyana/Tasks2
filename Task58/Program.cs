//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//https://studwork.org/spravochnik/matematika/matricy/umnojenie-matric - как умножать матрицы

Console.WriteLine("Введите количество строк матрицы 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1: ");
int num11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин элемент матрицы 1: ");
int minElem1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите макс элемент матрицы 1: ");
int maxElem1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк матрицы 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 2: ");
int num22 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин элемент матрицы 2: ");
int minElem2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите макс элемент матрицы 2: ");
int maxElem2 = Convert.ToInt32(Console.ReadLine());

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

int[,] matrix3 = new int[i, j];

proizvedMatrix(martrix1, martrix2, matrix3);
Console.WriteLine($"Произведение первой и второй матриц: ");
WriteArray(matrix3);

void proizvedMatrix(int[,] martrix1, int[,] martrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      matrix3[i,j] = sum;
    }
  }
}

int[,] matrix1 = CreateMatrixRndInt(num1, num11, minElem1, maxElem1);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(num2, num22, minElem2, maxElem2);
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(matrix3);