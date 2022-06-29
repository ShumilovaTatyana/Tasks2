// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string GetPalindrom(int a, int b, int c, int d, int e)
{
    if (a == e && b == d) return "да";
    return "нет";
}
string result = GetPalindrom(num);
Console.WriteLine(result);