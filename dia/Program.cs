
string[] arr = {"hello", "2", "world", ":-)"};

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int LenArray(string[] array)
{
    int lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) lenght++;
    }
    return lenght;
}

string[] rezArray = new string[LenArray(arr)];
var rezSize = 0;

foreach (var i in arr)
{
    if (i.Length <= 3)
    {
        rezArray[rezSize] = i;
        rezSize++;
    }
}

PrintArray(arr);
PrintArray(rezArray);