/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между
 максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76  */


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





/*
Console.Clear();
// заполняем массив рандом числами в диапазоне (1, 100);
void Random(int[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(1, 100);
    }
}
// вывод на экран
void Print(int[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        System.Console.Write(massiv[i] +" ");
    }
    System.Console.WriteLine();
}

// поиск max
int Max(int[]massiv)
{
    int max = 0;
    //int min = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i] > max)  max = massiv[i];
        //else (massiv[i] < min)  min = massiv[i];  
    }
    return max;
}
/*поиск min
int Min(int[]massiv)
{
    int min = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if(massiv[i] < min)  min = massiv[i];
    }
    return min;
}  

int[] massiv = new int [5];
Random(massiv);
Print(massiv);

System.Console.WriteLine($"Max {Max(massiv)}");
//System.Console.WriteLine($"Min {Min(massiv)}");

*/