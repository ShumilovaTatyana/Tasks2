// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstDigit = num / 10;
int thirdDigit = num % 10;
int result = thirdDigit % 10;
Console.Write(result);

// Console.WriteLine ("третьей цифры нет");




// int ShowSecondDigit(int number)
// {
//     int firstDigit = number / 100;
//     int secondDigit = number % 100 / 10;
//     return secondDigit;
// }
// int showSecondDigit = ShowSecondDigit (num);
// Console.Write(showSecondDigit);

// static int GetSecondDigit(int k)
// {
//     while (k >= 100) k /= 10;
//     int d = k % 10;
//     return d;
// }