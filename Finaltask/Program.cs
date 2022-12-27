string[] CreateArrayRndInt (int size)
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
        if(i < array.Length -1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int CountLessFour(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) count++;
    }
    return count;
}

string[] array = CreateArrayRndInt(4);
PrintArray(array);
int newSize = CountLessFour(array);
