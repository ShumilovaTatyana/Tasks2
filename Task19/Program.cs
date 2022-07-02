// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// void GetPalindrom (num);
//     if (num[0] == num[4] && num[1] == num[3]) return "да";
//     return "нет";
// string result = GetPalindrom(num);
// Console.WriteLine(result);


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckPalindrom(string number1);
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"да");
}
    else Console.WriteLine($"нет");
}
string checkPalindrom = CheckPalindrom(number);



// int[] array = { };
// int index = 0;
// void GetPalindrom(Array);

// while (index < array.Length)
// {
//     if (index[0] == index[4] && index[1] == index[3]) Console.Write($"да");
//     else Console.Write($"нет");
// }