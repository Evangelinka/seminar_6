// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] GetNumberFibonacci(int N)
{
    int[] array = new int[N];

    for (int i = 2; i < array.Length; i++)
    {
        array[0] = 0;
        array[1] = 1;
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

void PrintArrayFibonacci(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] array = GetNumberFibonacci(7);
PrintArrayFibonacci(array);