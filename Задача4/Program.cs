/* Задать одномерный массив из 123 случайных чисел. Найти кол-во 2-х значных
элементов массива*/

//функция которая заполняет массив рандом числами
void Random(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-100, 200);
    }
}
// функция ищет 2-х значные числа
int ToPlace(int[]mas)
{   
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        // if(mas[i] > 9 && mas[i] < 100)   // находит только положительные 2-х значные
        if(Math.Abs(mas[i]) > 9 && Math.Abs(mas[i]) < 100)  // ищет среди всех чисел 2-х значные
        count++;
    }
    return count;
}
// вывод на экран
void Print(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if(i % 10==0)
            System.Console.WriteLine();
        System.Console.Write($"{mas[i]} ");
        
    }
    System.Console.WriteLine();
}

int[]mas = new int[123];
Random(mas);
Print(mas);
System.Console.WriteLine($"Количество 2-х значных чисел в массиве равно: {ToPlace(mas)} ");


