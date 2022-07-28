

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max +1);

        Console.Write(newArray[i] + "  ");
    }
    Console.WriteLine();

    return newArray;
}