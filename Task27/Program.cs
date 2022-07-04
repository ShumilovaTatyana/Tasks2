// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int num1)
{
    int sum1 = 0;
    while (num > 0)
    {
        sum1 = sum1 + num % 10;
        num = num / 10;
    }
    return sum1;
}
int sum = Sum(num);
Console.WriteLine($"Сумма чисел = {sum}");

