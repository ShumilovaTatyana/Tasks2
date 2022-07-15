

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        index++;
    }
    return array;
}

