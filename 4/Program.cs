// Задача 24: Напишите программу, которая
//  принимает на вход число (А) и выдаёт
//   сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// возвращающее значение + Название + ()+ {}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int start = 1;
    int sum = 0;
    while (start <= num)
    {
        sum += start;
        start++;
        // start = start+1;
    }
    return sum;
}

// int result = GetSum();
// System.Console.WriteLine(result);

Console.WriteLine(GetSum());

Задача 26: Напишите программу, которая 
принимает на вход число и выдаёт количество 
цифр в числе.
456 -> 3
78 -> 2
89126 -> 5


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetCountNumber(num));

int GetCountNumber(int newNum)
{
    int count = 0;

    while (newNum > 0)
    {
        newNum = newNum / 10;
        count++;
    }

    return count;
}

Задача 28: Напишите программу, которая принимает
 на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum()
{
    int start = 1;
    int multiplication = 1;

    while (start <= num)
    {
        multiplication *= start;
        start++;
        // start = start+1;
    }
    return multiplication;
}

// int result = GetSum();
// System.Console.WriteLine(result);

Console.WriteLine(GetSum());


Задача 30: Напишите программу, которая выводит 
массив из 8 элементов, заполненный нулями и единицами 
в случайном порядке.
[1,0,1,1,0,1,0,0]

void CreateArray()
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        System.Console.Write(array[i] + " ");
    }
}

CreateArray();