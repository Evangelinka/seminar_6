// Программа, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];    
    }
    return newArray;
}

int[] array = CreateArray(10, 0, 9);
PrintArray(array);
Console.WriteLine();
PrintArray(CopyArray(array));