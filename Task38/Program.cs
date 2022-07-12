// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 100);
        Console.Write(array[index] + " ");
        index++;
        
    }
    return array;
}

int[] GetMaxElemMinElem(int[] arr)
{
int max = arr[0];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
     {
        max = arr[i];
     }
     if (arr[i] < min)
     {
        min = arr[i];
     }
}
return new[] {min, max};
}

//int Raznitsa
int[] array = CreateArrayRndInt(5);
int[] getMaxElemMinElem = GetMaxElemMinElem(array);

Console.WriteLine();
Console.WriteLine($"Максимальное значение = {getMaxElemMinElem[1]}, минимальное значение = {getMaxElemMinElem[0]}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {getMaxElemMinElem[1] - getMaxElemMinElem[0]}");


