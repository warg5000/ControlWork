//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
//["1234", "1567", "-2", "computer science"] → [“-2”]
//["Russia", "Denmark", "Kazan"] → []
string[] ResultArray(string[] array)
{
    int a = 0;
    int b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            a++;
        }
    }
    string[] newarr = new string[a];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[b] = array[i];
            b++;
        }
    }
    return newarr;
}
void PrintArray(string[] array)
{
    if (array.Length == 0) {Console.WriteLine("[]");}
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}
string[] array = ["Russia", "Denmark", "Kazan"];
string[] result = ResultArray(array);
PrintArray(result);