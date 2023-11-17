//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Алгоритм нужно реализовать самостоятельно, встроенную функцию использовать нельзя.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int RaiseN(int num, int num1) 
{
  int a = num; 
  int result = 1;
  for (int i = 1; i < num1; i++)    
  {
   result = num * a;
   num = result;
  }
  return result;
}
Console.WriteLine("Введите два числа");
Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n1 = Convert.ToInt32(Console.ReadLine());
int res = RaiseN(n, n1);
Console.WriteLine($"Возведение первого числа в степень равную второму числу равно {res}");