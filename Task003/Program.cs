﻿/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber > 5)
{
    Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("рабочий");
}
