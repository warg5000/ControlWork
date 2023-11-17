// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void FillArrayAndShowSubsOfMaxAndMin(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 100) + Math.Round(rnd.NextDouble(), 2, MidpointRounding.ToZero);
    }
    double max = MaxInArray(array);
    double min = MinInArray(array);
    double subs = max - min;
    string result = string.Join(" ", array);
    Console.WriteLine(result);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равно {subs}");
}
double MaxInArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
double MinInArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
Random rnd = new Random();
int size = rnd.Next(101);
double[] arr = new double[size];
FillArrayAndShowSubsOfMaxAndMin(arr);

