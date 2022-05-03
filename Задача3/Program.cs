/*  Написать программу- замена элемнтов массива: положительные элементы
заменить на отрицательные и наоборот. */

//функция которая заполняет массив рандом числами
void Random(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-10, 10);
    }
}
// функция замены 
void Replace(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = -mas[i];
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

int[] mas = new int [10];

Random(mas);
Print(mas);
Replace(mas);
Print(mas);






