// 18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x, y)

// Console.WriteLine("Введите номер четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string Coord (int a)
// {
//     if (a == 1) return "x > 0 и y > 0";
//     if (a == 2) return "x < 0 и y > 0";
//     if (a == 3) return "x < 0 и y < 0";
//     if (a == 4) return "x > 0 и y < 0";
//     return "некорректный ввод";
// }
// string result = Coord(num);
// Console.WriteLine(result);

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string result;
string Coord (int a)
{
    string res = "";
    if (a == 1) res = "x > 0 и y > 0";
    if (a == 2) res = "x < 0 и y > 0";
    if (a == 3) res = "x < 0 и y < 0";
    if (a == 4) res = "x > 0 и y < 0";
    return res;
}
if (num > 0 && num < 5)
{
    result = Coord(num);
}
else
{
    result = "некорректный ввод";
}
Console.WriteLine(result);