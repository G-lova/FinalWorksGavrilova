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