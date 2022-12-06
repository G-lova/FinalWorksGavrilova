string[] CreateStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine("]");
}

string[] ReformedStringArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            size++;
    string[] reformedArray = new string[size];
    for (int i = 0, j = 0; i < array.Length; i++, j++)
    {
        if (array[i].Length <= 3)
            reformedArray[j] = array[i];
        else
            j--;
    }
    return reformedArray;
}

