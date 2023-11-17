void Table(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 6} -> {i*i*i, 6}");
        i++;    
    }  
}
Console.WriteLine("Введите натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Table(n);
