// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int finalResult = SumOfTheDigit(num);
Console.WriteLine(finalResult);

int SumOfTheDigit(int digit)
{
    if (digit > 0)
    {
        return digit % 10 + SumOfTheDigit(digit / 10);
    }
     return 0;
}