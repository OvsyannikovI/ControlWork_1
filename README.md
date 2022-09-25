## Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

массив строк:
* ["hello", "2", "world", ":-)"]
* ["12345", "1567", "-2", "computer science"]
* ["Russia", "Denmar", "Kazan"]

## Решение на С#  

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


    var rez = new string[arr.Length];
    var rezSize = 0;
    foreach (var i in arr)
    {
        if (i.Length <= 3)
        {
            rez[rezSize] = i;
            rezSize++;
        }
    }

    PrintArray(arr);
    PrintArray(rez);
