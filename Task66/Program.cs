//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumOfNums(int m, int n)
{
    if (m < 0 || n < 0)
    {
        throw new Exception("Ошибка, все числа должны быть натуральными");
    }
    if (m == n) return m;
    return m + SumOfNums(m - Math.Sign(m - n), n);
}
try
{
    Console.WriteLine("Задайте первое натуральное число");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте второе натуральное число");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = SumOfNums(m, n);
    Console.WriteLine($"Сумма натуральных числе в промежутке от M до N = {result}");
}
catch (System.FormatException)
{
    Console.WriteLine("Вы не смогли ввести число");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
