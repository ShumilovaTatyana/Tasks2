﻿// Дополнительные задачи.
// Задача 14: Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
Console.WriteLine($"да");
}
else
{
    Console.WriteLine($"нет");
}

// int MultDigit(int number)
// {
//     return (num % 7 == 0 && num % 23 == 0);
// }
// int multDigit = MultDigit (num);
// Console.Write(multDigit);
