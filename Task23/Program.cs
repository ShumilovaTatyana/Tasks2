﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
void GetCube (int a)
{
    int index = 1; 
    while(index <= a) 
    {
        int cube = index * index * index;
        Console.Write($"{cube} ");
        index++;
    }
}
GetCube(num);