﻿// 21.

Console.WriteLine("Ввести данные координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести данные координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести данные координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести данные координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int a1, int b1, int a2, int b2)
{
    double res = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2));
    res = Math.Round(res,2);
    return res;
}
double result = GetDistance(x1, y1, x2, y2);
Console.WriteLine(result);
