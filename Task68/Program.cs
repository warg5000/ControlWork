//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int Ack(int m, int n)
{
     if (m < 0 || n < 0)
    {
        throw new Exception("Ошибка, все числа должны быть положительными");
    }
    if (m == 0) return n + 1;
    if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
try
{
    Console.WriteLine("Задайте первое положительное число m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте второе положительное число n");
    int n = Convert.ToInt32(Console.ReadLine());
    int Ackerman = Ack(m, n);
    Console.Write($"Функция Аккермана = {Ackerman}");
}
catch (System.FormatException)
{
    Console.WriteLine("Вы не смогли ввести число");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}