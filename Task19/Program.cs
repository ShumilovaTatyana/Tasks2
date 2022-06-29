// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num[0] = Convert.ToInt32(Console.ReadLine());
// void GetPalindrom (num)
if (num[0] == num[4] && num[1] == num[3])
{
    Console.WriteLine($"да");
}
else
{
  Console.WriteLine($"нет");  
}
// {
//     if (num[0] == num[4] && num[1] == num[3]) return "да";
//     return "нет";
// }
// string result = GetPalindrom(num);
// Console.WriteLine(result);