// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26


Console.Clear();
Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int col = int.Parse(Console.ReadLine());
Console.WriteLine();

int GetSumOfTheNembers(int first, int second, int count)
{
    if (count == 0) return first;
    if (count == 1) return second;
    int sum = GetSumOfTheNembers(first, second, count-1) + GetSumOfTheNembers(first, second, count-2);
    return sum;
}
for (int i = 0; i < col; i++)
{
   Console.Write($"{GetSumOfTheNembers(num1, num2, i)} ");
}