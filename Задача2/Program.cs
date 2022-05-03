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
// Вывод массива на экран
void Print(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}
// функция которая меняет элементы
void Find(int[]mas, int f)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i] == f)
        {
            System.Console.WriteLine("Да, индекс: " + i);
            return;
        }
    }
    System.Console.WriteLine("Нет совпадений");
}

int[] mas = new int [10];

Random(mas);
Print(mas);
int x = Convert.ToInt32(Console.ReadLine());
Find(mas, x);





