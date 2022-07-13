// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты точки b и k: ");
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int x = (b2 - b1)/(k1 - k2);
double Peresechenie(int b1, int k1, int b2, int k2)
{
    double res = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2));
    res = Math.Round(res,2);
    return res;
}
double result = Peresechenie(x1, y1, x2, y2);
Console.WriteLine(result);
('Точка пересечения: (', x, ';', k1*x + b1, ')');
