// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число m: ");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numN = int.Parse(Console.ReadLine());

int functionAkkerman = Function(numM, numN);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Function(int m, int n)
{
  if (m == 0) return n + 1;
  else if (m > 0 && n == 0) return Function(m - 1, 1);
  else return Function(m - 1, Function(m, n - 1));
}
Function(numM, numN);
