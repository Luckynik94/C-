//9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);

// int num1 = num / 10;
// int num2 = num % 10;
// if (num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }

// Решение в группах задач:
// 11. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// using System.Security.Principal;

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;

// int result = num1 * 10 + num2;

// Console.WriteLine(result);


// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Vesty 1 count");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Vesty 2 count");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("two count krt one");
// }
// else
// {
//     Console.WriteLine($"don't krt one - {num1 % num2}");
// }

// sposoby
// Console.WriteLine("1"+num+"2") - Канкатинация
// Console.WriteLine($"1{num}2") - Интерполяция



// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.WriteLine("Vesty 1 count");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("NO");
// }

// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Vesty 1 count");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vesty 2 count");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("NO");
}