// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// В задаче 41 в решении вводятся числа, а в цикле они для подсчёта не используются.
// Цикл не работает, т.к. в метод передаётся 0 (numm) и count = 0.

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 4: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 5: ");
int num5 = Convert.ToInt32(Console.ReadLine());
int numm = 0;

int ShowQuantity(int num)
{
    int i = 0;
    int count = 0;
    while (i < num)
    {
        if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0 && num5 > 0)
            count = count + 1;
        i++;

    }
    return count;
}

int showQuantity = ShowQuantity(numm);
Console.WriteLine();
Console.WriteLine($"сколько чисел больше 0 ввёл пользователь = {showQuantity}");


