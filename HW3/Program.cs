﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number == "1" || number == "2" || number == "3" || number == "4" || number == "5")
{
    Console.WriteLine($"{number} -> не выходной");
}
else if (number == "6" || number == "7")
{
    Console.WriteLine($"{number} -> выходной день");
}
else
{
    Console.WriteLine("Нет такого дня");
}
