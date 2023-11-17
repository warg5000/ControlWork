Console.WriteLine("Введите первое число");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;
if (max < n2)
{
    max = n2;
}
if (max < n3)
{
    max = n3;
}
Console.WriteLine(max);