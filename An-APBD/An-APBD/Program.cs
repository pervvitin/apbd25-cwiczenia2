﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MODYFIKACJA 1");
Console.WriteLine("MODYFIKACJA 2");
Console.WriteLine("MODYFIKACJA 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double) sum / numbers.Length;
}
