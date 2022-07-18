// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrix);

Console.WriteLine("Введите позицию строки: ");
int position0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца: ");
int position1 = Convert.ToInt32(Console.ReadLine());
string result;
double ShowElem (int a)
{
    string res = "";
    if(
   position0 <= m 
&& position1 <= n 
&& position0 >= 0 
&& position1 >= 0);
}
