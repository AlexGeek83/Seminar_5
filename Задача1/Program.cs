/* Задать массив из 12 элементов, заполненный случайными числами из промежутка
от -9 до 9. Найти сумма отрицательных м положительных элементов массива
*/

// создаем функцию которая ставит рандом элементы в массив от -9 до 9
void Random(int[] mas) 
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-9, 10);
    }
}

// метод который печатает массив
void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}

//функция которая считает сумму положительных элементов
int SumPositive(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] > 0) 
            result += mas[i];
    }
    return result;
}

//функция которая считает сумму отрицательных элементов
int SumNegative(int[] mas)
{
    int result = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] < 0) 
            result += mas[i];
    }
    return result;
}

int[] massiv = new int[12]; // задаем массив int[] massiv и выделяем для него память new int[12]
Random(massiv);
Print(massiv);

System.Console.WriteLine($"Сумма положительных элементов = {SumPositive(massiv)}");
System.Console.WriteLine($"Сумма отрицательных элементов = {SumNegative(massiv)}");







