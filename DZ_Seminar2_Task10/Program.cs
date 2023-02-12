// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int middle = num / 10 % 10;
    System.Console.WriteLine(middle);
}