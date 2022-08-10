// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int threeDigit = Convert.ToInt32(Console.ReadLine());

string stringNumber = Convert.ToString(threeDigit);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);

