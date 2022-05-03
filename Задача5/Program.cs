/* Найти произведение пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и т.д.
Результат записсать в новом массиве. */



//функция которая заполняет массив рандом числами
void Random(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(1, 10);
    }
}
// Вывод массива на экран
void Print(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}
//
void Play(int[]mas)
{
    int n1 = mas.Length; // можно укоротить mas.Length - заменить на n1
    
    int[]mas2 = new int[mas.Length/2 + mas.Length%2]; // создаем новый массив для перезаписи
    int n2 = mas2.Length;  // можно укоротить mas.Length2 - заменить на n2
    for (int i = 0; i <= mas.Length / 2; i++) // дойдет до половины
    {
        mas2[i] = mas[i] * mas[mas.Length - 1 - i]; // перезаписываем в новый массив, также
        // можно заменить запись mas[mas.Length - 1 - i] на mas[^(i+1)]
    
    }
    if(mas.Length%2 != 0) // проверка не равно 0
    {
        mas2[mas2.Length - 1] = mas[mas.Length/2]; // если нечетное кол-во эл-тов в массиве, то 
        // середину пересохраняем
    }
    Print(mas2);
}

int[]mas = new int[5];

Random(mas);
Print(mas);
Play(mas);

