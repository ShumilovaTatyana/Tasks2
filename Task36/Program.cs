// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 100);
        Console.Write(array[index] + " ");
        index++;
        
    }
    return array;
}

int[] GetSumOddElem(int[] arr)
{
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
     {
        sum = sum + arr[i];
     }
}
return new[] {sum};
}

int[] array = CreateArrayRndInt(4);
int[] getSumOddElem = GetSumOddElem(array);

Console.WriteLine();
Console.WriteLine($"суммa элементов, стоящих на нечётных позициях = {getSumOddElem[0]}");

// int [] sum = GetSumOddElem(array1);
// Console.WriteLine();
// Console.WriteLine($"суммa элементов, стоящих на нечётных позициях = {GetSumOddElem[0]}");
