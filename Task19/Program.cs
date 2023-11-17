//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да
static bool PalindromeCheck(int n)
{
    int rev = 0, check = n;

    while (n > 0)
    {
        rev = rev * 10 + n % 10;
        n /= 10;
    }
    return check == rev;
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
bool palindromeCheck = PalindromeCheck(num);
Console.WriteLine(palindromeCheck
? ("Число является палиндромом")
: ("Число не является палиндромом")
);