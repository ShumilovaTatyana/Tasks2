// Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполняет нулями и единицами в случайном порядке.

// int[] array = new int[8];
// int index = 0;
// var rnd = new Random();

// while (index < array.Length)
// {
//     array[index] = rnd.Next(0, 2); // двойка не входит в диапазон, т.е будет 0 и 1
//     index++;
// }
// for (int i = 0; i < array.Length; i++)
// {
//     if(i == 0) Console.Write("[");
//     if(i < array.Length - 1) Console.Write(array[i] + ",");
//     else Console.Write(array[i] + "]");

// }

int[] array = new int[8];
int[] array1 = {3, 5, 8, 8};
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index = 0;
var rnd = new Random();

while (index < array.Length)
{
    array[index] = int.Parse(Console.ReadLine());
    index++;
}
for (int i = 0; i < array.Length; i++)
{
    if(i == 0) Console.Write("[");
    if(i < array.Length - 1) Console.Write(array[i] + ",");
    else Console.Write(array[i] + "]");

}