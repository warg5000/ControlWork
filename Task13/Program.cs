Console.WriteLine("Введите число");
string? n = Console.ReadLine()?.TrimStart('-');
if (n == null || !int.TryParse(n, out int garbage) || n.Length <= 2)
{
    Console.WriteLine("Число состоит из менее 3 цифр или это не число");
}
else
{
    char res = n[2];
    Console.WriteLine($"Третья цифра числа = {res}");
}
