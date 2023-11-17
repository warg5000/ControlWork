//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void ShowAveragePerRow(int rows, int columns, int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    double summ = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
summ = summ + matrix[i,j];
    }
    double avg = summ / columns;
    Console.WriteLine($"Среднее арифметическое строки {i+1} равняется {Math.Round(avg, 2 , MidpointRounding.ToZero)}");
}
}
Random rnd = new Random();
int rows = rnd.Next(3, 11);
int columns = rnd.Next(3, 11);
int[,] result = FillMatrix(rows, columns);
PrintMatrix(result);
ShowAveragePerRow(rows, columns, result);
