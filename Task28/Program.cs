// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int Proizved (int num1)
{
    int proizved1 = 1;
    for(int i = 1; i <= num1; i++)
    {
        proizved1 = proizved1 * i;
    }
    return proizved1;
}
int proizved = Proizved(num);
Console.WriteLine($"произведение чисел от 1 до {num} = {proizved}");
