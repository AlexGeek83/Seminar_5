Console.Clear();

int massiv = new Random().Next(1, 11); // рандомное кол-во эл-тов массива в диапазоне

System.Console.WriteLine($"Кол-во элементов массива: {massiv}");

int[] FillSourceArray(int massiv)
{
    int[] array = new int[massiv];
    for (int i = 0; i < massiv; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
    return array;
}

void PrintDiffMinMax(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    int diff = arr.Max() - arr.Min();
    System.Console.WriteLine($"Мин. значение массива {arr.Min()}, макс. значение массива {arr.Max()}");
    System.Console.WriteLine($"Разница между мин. и макс. значениями массива составляет {diff}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillSourceArray(massiv));


