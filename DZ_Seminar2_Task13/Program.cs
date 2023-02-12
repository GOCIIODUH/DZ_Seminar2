// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число и я определю третие цифру заданного числа: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int index = 1;
int num = number;
while (num / 10 > 0)
{
    num = num / 10;
    index++;
}
if (index < 3)
{
    System.Console.WriteLine("Ваше число не соответствует требованиям, пожалуйста введите не менее 3 цифр");
}
else
{
    for (int i = 1; i < index - 2; i++)
    {
        number = number / 10;
    }
    int three = number % 10;
    System.Console.WriteLine("Третия цифра " + three);
}
