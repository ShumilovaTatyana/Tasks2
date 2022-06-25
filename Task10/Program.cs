// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
// int firstDigit = num / 100;
// int secondDigit = num % 100 / 10;

// int result = secondDigit;
// Console.Write(result);

int ShowSecondDigit(int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 100 / 10;
    return secondDigit;
}
int showSecondDigit = ShowSecondDigit (num);
Console.Write(showSecondDigit);
