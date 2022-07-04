// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum (int num1)
{
    int sum1 = 0;
    for(int i = 1; i <= num1; i++)
    {
        sum1 = sum1 + i;
    }
    return sum1;
}
int sum = Sum(num);
Console.WriteLine($"Сумма чисел {num} = {sum}");
