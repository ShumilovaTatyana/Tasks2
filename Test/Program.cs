
// вещественные числа
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        index++;
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++);
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length -1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
double[] array = CreateArrayRndDouble(3, 4, 1, 20);
PrintMatrix(array);