// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int GetLengthArray(int number)
{
    int len = 0;
    while (number >= 1)
    {
        number = number / 2;
        len++;
    }
    return len;
}

int[] ConvertToBinaryNumber(int number)
{
    int[] array = new int[GetLengthArray(number)];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 2;
        number = number / 2;
    }
    return array;
}

void PrintConvertToBinaryNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] arr = ConvertToBinaryNumber(47);
PrintConvertToBinaryNumber(arr);