
string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word ");
        words[i] = Console.ReadLine();
    }
    return words;
}

void Threelongsymbol(string[] array, string[] array2)
{
    string[] array = new string[size];
    string[] array2 = new string[array1.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
