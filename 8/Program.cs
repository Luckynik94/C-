// Задача 53: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[rows, columns];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); //0,9
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeArray()
{
    int rowCount = array.GetLength(0) - 1;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[rowCount, i];
        array[rowCount, i] = temp;
    }
}

CreateArray();
PrintArray();
ChangeArray();
System.Console.WriteLine();
PrintArray();

// Задача 55: Задайте двумерный массив. Напишите
// программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.

Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, rows];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); //0,9
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeArray()
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resultArray[j, i] = array[i, j];
        }

    }
    return resultArray;
}

CreateArray();
PrintArray(array);

System.Console.WriteLine();
PrintArray(ChangeArray());

Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7


Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, rows];
int minElement = 10;
int minRow = 0;
int minColumn = 0;

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); //0,9

            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ChangeArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != minRow && j != minColumn)
            {
                System.Console.Write(array[i, j] + "\t");
            }
        }
        System.Console.WriteLine();
    }
}

CreateArray();
PrintArray(array);

System.Console.WriteLine();
ChangeArray();