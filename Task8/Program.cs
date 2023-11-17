Console.WriteLine("Введите число 2 и более");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 2)
{
    Console.Write("Создание числового ряда невозможно, необходимо ввести число больше 1");
}
else
{
    string res = "";
    for (int i = 2; i <= n; i += 2)
    {
        res += $"i = {i}, ";
    }
    Console.Write(res.TrimEnd(' ').TrimEnd(',') + ".");
}