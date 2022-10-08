﻿/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void GetCubsUpToNum(int N)
{
    Console.Write($"{N} -> ");

    for (int i = 1; i <= N; i++)
    {
        double cub = Math.Pow(i, 3);
        Console.Write($"{cub} ");
    }
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
GetCubsUpToNum(number);