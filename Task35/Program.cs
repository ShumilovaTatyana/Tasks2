// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] array = { 1, 2, 3, 4, 5 };
int[] GetProizved(int [] arr)
{
    if (arr.Length % 2)
    int[] newArr = new int[];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArr;
}
int[] newArray = GetProizved(array);
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.WriteLine(arr[i] + "+");
        else Console.WriteLine(arr[i]);
    }
}
PrintArray(newArray);

35
int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 200);
        Console.Write(array[index] + " ");
        index++;
        
    }
    return array;
}
int[] array1 = CreateArrayRndInt(5);


int FindNum(int[] arr)
{
    int i = 0;
    int count = 0;
    while (i < arr.Length)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count = count + 1;
        i++;
        
    }
    return count;
}

int count1= FindNum(array1);
Console.WriteLine();
Console.WriteLine(count1);
