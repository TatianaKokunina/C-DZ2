﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число=");
int Number = Convert.ToInt32(Console.ReadLine());

int NewNumberSearch(int Number)
{
   int serNumber = (Number / 10) % 10;
   return serNumber;
}

int serNumber = NewNumberSearch(Number);
Console.WriteLine($"У числа {Number} вторая цифра= {serNumber}");