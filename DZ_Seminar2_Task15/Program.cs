// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0 && number<6) System.Console.WriteLine("нет");
if (number ==6 || number ==7) System.Console.WriteLine("да");
if (number <1 || number>7) System.Console.WriteLine("Ошибка ввода, требуется ввести зничение от 1 до 7");
