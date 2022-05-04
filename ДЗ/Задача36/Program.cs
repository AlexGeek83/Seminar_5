/*  Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


Console.Clear();
// заполняем массив рандом числами в диапазоне (-10, 30);
void Random(int[]massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = new Random().Next(-10, 30);
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
// проверка на нечетность
int Sum(int[] massiv)
{
    int result = 0;
    for (int i = 1; i < massiv.Length; i++)
    {
        if(i % 2 != 0) result += massiv[i];
        
    }
    return result;
}

int[] massiv = new int [5];

Random(massiv);
Print(massiv);
System.Console.WriteLine($"Сумма эл-тов в массиве на нечетных позициях = {Sum(massiv)}");


