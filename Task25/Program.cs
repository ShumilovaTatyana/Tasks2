// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i =1; i <= number; i++)
// {
//     sum += i; //sum = sum + i;

//     if(i < number) Console.Write($"{i} + ");
//     else Console.Write($"{i} = ");
// }
//  Console.WriteLine($"{sum}");

Console.WriteLine("Введите число A: ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numb = Convert.ToInt32(Console.ReadLine());
int RaiseDegree = num;
{
    int raiseDegree1 = 1;
    for(int i = 1; i <= num; i++)
    {
        raiseDegree1 = numa^numb;
    }
    return raiseDegree1;
}
int raiseDegree = RaiseDegree(num);
Console.WriteLine($"Число А {numa} в степени числа B {numb} = {RaiseDegree}");
