// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int SumOfNums(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumOfNums(num);
Console.WriteLine(result);
