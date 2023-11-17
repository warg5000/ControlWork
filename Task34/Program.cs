// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void FillArrayAndShowEvenNums(int[] array)
{
    Random rnd = new Random();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(101, 1000);
    }
    for (int a = 0; a < array.Length; a++)
    {
        if (array[a] % 2 == 0)
        {
            count++;
        }
    }
    string result = string.Join(" ", array);
    Console.WriteLine(result);
    Console.WriteLine($"Количество чётных числе в массиве равно {count}");
}
int[] arr = new int[8];
FillArrayAndShowEvenNums(arr);