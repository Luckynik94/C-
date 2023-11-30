// Задача 46: Задайте двумерный массив размером
// m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

System.Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine()); //3

System.Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine()); //5

int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}


// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

System.Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int columns = new Random().Next(1, 5);
System.Console.WriteLine("Случайное число " + columns);

int[,] array = new int[rows, columns];

int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        System.Console.Write(array[i, j] + " ");

        if (i == j)
        {
            count = count + array[i, j];
        }
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Сумма на гл. диаг. = " + count);

// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2 1 4 49 2
// 5 9 2 3 5 9 2 3
// 8 4 2 4 64 4 4 4

System.Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}