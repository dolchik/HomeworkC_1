﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Ввеите число: ");
int N = int.Parse(Console.ReadLine());
int count = 2;

if (N > 0)
{
    while (count <= N)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
}

