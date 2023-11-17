Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n1>n2) 
{
    max = n1;
}
else 
{
    max=n2;
}
Console.WriteLine(max);
