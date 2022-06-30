// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = -num;
// void GetPalindrom (num)
// if (num1 == num)
// {
//     Console.WriteLine($"да");
// }
// else
// {
//     Console.WriteLine($"нет");
// }
// {
//     if (num[0] == num[4] && num[1] == num[3]) return "да";
//     return "нет";
// }
// string result = GetPalindrom(num);
// Console.WriteLine(result);


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number);
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"да");
}
    else Console.WriteLine($"нет");
}
// if (number!.Length == 5)
// {
//  CheckingNumber(number);
// }
// else Console.WriteLine($"ошибка ввода!");
