﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
