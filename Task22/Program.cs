// Задача 22.

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
void GetQuad (int a)
{
    int index = 1; 
    while(index <= a) 
    {
        int quad = index * index;
        Console.Write($"{quad} ");
        index++;
    }
}
// string result = GetQuad(num);
GetQuad(num);