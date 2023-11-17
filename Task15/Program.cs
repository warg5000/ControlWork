Console.WriteLine("Введите цифру текущего дня недели, где 1 - понедельник");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Сегодня выходной!");
}
else
{
    Console.WriteLine("Сегодня рабочий день");
}
