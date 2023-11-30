// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int startNum = 1;

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }

    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(startNum, num));

// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(PrintNumbers(num2, num1));
}
else if (num1 < num2)
{
    Console.WriteLine(PrintNumbers(num1, num2));
}
else
{
    System.Console.WriteLine("Числа равны");
}

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }

    return (start + " " + PrintNumbers(start + 1, end));
}

// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int PrintNumbers(int num)
{
    if (num == 0)
    {
        return 0;
    }

    return (num % 10 + PrintNumbers(num / 10));
}

System.Console.WriteLine(PrintNumbers(num1));

Задача 69: Напишите программу, которая на вход
принимает два числа A и B, и возводит число А
в целую степень B с помощью рекурсии.
A = 3; B = 5-> 243(3⁵)
A = 2; B = 3-> 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int runk)
{
    if (runk == 0)
    {
        return 1;
    }
    if (runk == 1)
    {
        return num;
    }

    // return (num * Pow(num,--runk));// декремент
    return (num * Pow(num, runk - 1));
}

System.Console.WriteLine(Pow(num, num1));