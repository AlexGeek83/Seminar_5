/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */

Console.Clear();
// заполняем массив рандом числами в диапазоне (100, 200);
void Random(int[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(100, 200);
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
// проверка на четность
int Count1(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] % 2 == 0) 
          result += 1;
    }
    return result;
}

// проверка на нечетность
int Count2(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] % 2 != 0) 
          result += 1;
    }
    return result;
}

int[] massiv = new int [10];

Random(massiv);
Print(massiv);
System.Console.WriteLine($"Количество четных чиел в массиве - {Count1(massiv)}");
System.Console.WriteLine($"Количество нечетных чиел в массиве - {Count2(massiv)}");
