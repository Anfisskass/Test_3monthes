string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} word ");
        words[i] = Console.ReadLine();
    }
    return words;
}


void NumberOfLongWords(string[] array, string[] array2)
{   
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

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateStringArray(size);
string[] array2 = new string[array.Length];

NumberOfLongWords(array, array2);
Console.WriteLine();
PrintArray(array2); 