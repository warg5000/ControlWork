Console.WriteLine("Введите трёхзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int a;
double res = n * 0.1 % 10;
a = (int)res;
Console.WriteLine(a);
