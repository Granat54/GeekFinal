string[] CreateArrayRndInt(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите значение:");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


string[] SortLessFour(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];
    int k = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[k] = arr[i];
            k++;
        }
    }
    return newArray;
}


string[] array = CreateArrayRndInt(4);
PrintArray(array);
string[] newArray = SortLessFour(array);
Console.Write(" -> ");
PrintArray(newArray);