// Задача 24. Напишите программу, котора принимает на вход число А и выдает сумму чисел от 1 до А.
// 7 - 28
// 4 - 10
// 8 - 36

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i =1; i <= number; i++)
// {
//     sum += i; //sum = sum + i;
// }
//  Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i =1; i <= number; i++)
// {
//     sum += i; //sum = sum + i;

//     if(i < number) Console.Write($"{i} + ");
//     else Console.Write($"{i} = ");
// }
//  Console.WriteLine($"{sum}");

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int Sum (int num)
// {
//     int sum1 = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum1 += i;
//     }
//     return sum1;
// }

// sum = Sum(number);
// int sum1 = Sum(5);
// Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");
// Console.WriteLine(sum1);

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int res = 1;
int start = 1;
while (start <= n)
{
    checked
    {
        res *= start; //res = res * start
        start++;
    }
}
Console.WriteLine(res);