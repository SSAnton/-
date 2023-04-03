string[] arrayString = new string[5] {"Хор", "Привет", "1990", "467", "gray"};

string[] FilterArray(string[] arr)
{
    int len = arr.Length;
    string[] result = new string[0];
    for (int i = 0; i < len; i++)
    {
        if(arr[i].Length <=3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = arr[i];
        }
    }

    return result;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}


PrintArray(arrayString);
Console.WriteLine();
PrintArray(FilterArray(arrayString));