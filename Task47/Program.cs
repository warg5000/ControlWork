//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
double[,] FillMatrix(int rows, int columns)
{
    Random rnd = new Random();
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(rnd.NextDouble() * 100, 2, MidpointRounding.ToZero);
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],10}");
        }
        Console.WriteLine("]");
    }
}
Random rnd = new Random();
int rows = rnd.Next(3, 11);
int columns = rnd.Next(3, 11);
double[,] result = FillMatrix(rows, columns);
PrintMatrix(result);