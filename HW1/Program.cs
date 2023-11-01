// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();

int number;
bool isNumber = int.TryParse(stringNumber, out number);

if (isNumber && stringNumber.Length == 3)
{
    Console.WriteLine($"{stringNumber} -> {stringNumber[1]}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число, либо там есть буквы.");
}