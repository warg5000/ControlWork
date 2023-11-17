// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void FillArrayAndShowSumm(int[] array)
{
    Random rnd = new Random();
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(101);
    }
    for (int a = 1; a < array.Length; a = a + 2)
    {
        summ = summ + array[a];
    }
    string result = string.Join(" ", array);
    Console.WriteLine(result);
    Console.WriteLine($"Сумма элементов массива на нечётных позициях равна {summ}");
}
Random rnd = new Random();
int size = rnd.Next(101);
int[] arr = new int[size];
FillArrayAndShowSumm(arr);
