// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (num != 0) // НЕ РАВНО
{
    num /= 10; // num = num / 10
    count++; // count = count + 1
}
Console.WriteLine($"количество цифр в числе {count}");