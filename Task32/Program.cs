// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]








Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//int[] array = new int[5];
int[] array = { 6, 7, 19, 345, 3 };
var rnd = new Random();
int index = 0;
// while (index < array.Length)
// {
//     array[index] = rnd.Next(0, 1000);
//     Console.Write($"{array[index]}  ");
//     index++;
// }
Console.WriteLine();
string CheckNumber(int[] arr, int num)
{
    string res = "нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) res = "Да";
    }
    return res;
}
string result = CheckNumber(array, number);
Console.WriteLine(result);
