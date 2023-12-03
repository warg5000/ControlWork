string[] ResultArray(string[] array)
{
    int limitForElementLength = 3;
    int newArrSizeCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limitForElementLength)
        {
            newArrSizeCounter++;
        }
    }
    string[] newArray = new string[newArrSizeCounter];
    newArrSizeCounter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limitForElementLength)
        {
            newArray[newArrSizeCounter] = array[i];
            newArrSizeCounter++;
        }
    }
    return newArray;
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