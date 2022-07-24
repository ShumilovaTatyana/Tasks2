// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numN = int.Parse(Console.ReadLine());
int sum = 0;

void SumNum(int numM, int numN, int sum)
{
    if (numM < numN)
    {
        sum = sum + numM + 1;
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    //sum = sum + numM + 1;
    SumNum(numM, numN, sum);
}
SumNum(numM, numN, sum);

