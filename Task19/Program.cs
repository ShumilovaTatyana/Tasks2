// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();
string CheckPalindrom = number;
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"да");
}
    else Console.WriteLine($"нет");
}


// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// if (num[0] == num[4] || num[1] == num[3])
// {
//     Console.WriteLine($"да");
// }
// else 
// {
//     Console.WriteLine($"нет");
// }

