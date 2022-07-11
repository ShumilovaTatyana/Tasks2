// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(100, 1000);
        Console.Write(array[index] + " ");
        index++;
        
    }
    return array;
}
int[] array1 = CreateArrayRndInt(4);


int ShowQuantity(int[] arr)
{
    int i = 0;
    int count = 0;
    while (i < arr.Length)
    {
        if (arr[i] % 2 == 0)
            count = count + 1;
        i++;
        
    }
    return count;
}

int count1= ShowQuantity(array1);
Console.WriteLine();
Console.WriteLine($"количество чётных чисел в массиве = {count1}");
