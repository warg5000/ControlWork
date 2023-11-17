﻿//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет
int[,] FillMatrix(int rows, int columns)
{
    Random rnd = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(-100, 100);
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}
void ShowTarget(int i, int j, int[,] matrix)
{
    if (i >= matrix.GetLength(0) || j >= matrix.GetLength(1))
    {
        Console.WriteLine("Указаны неверные данные");
    }
    else
    {
        Console.WriteLine($"Указанным данным соответсвует элемент {matrix[i, j]}");
    }
}
Random rnd = new Random();
int rows = rnd.Next(3, 11);
int columns = rnd.Next(3, 11);
int[,] result = FillMatrix(rows, columns);
PrintMatrix(result);
Console.WriteLine("Введите нужные Вам координаты элемента");
Console.WriteLine("Введите номер строки");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int j = Convert.ToInt32(Console.ReadLine());
ShowTarget(i, j, result);
