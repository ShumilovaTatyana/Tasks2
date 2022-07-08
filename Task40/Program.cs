// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
// if (a < b + c && b < a + c && c < a + b)
// {
//     Console.WriteLine($"Да");
// }
// else Console.WriteLine(" Нет");

bool Triangle(int ad, int bd, int cd)
{
    return ad < bd + cd && bd < ad + cd && cd < ad + bd;
}
bool res = Triangle(a, b, c);
Console.WriteLine(res ? "да": "нет");