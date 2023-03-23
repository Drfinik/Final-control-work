// Написать программу, которая из имеюшегося
// массива строк формирует массив из строк,
// длина которых <=3 символа.

void MethodCreateFirstArray(string[] firstArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < firstArray.Length; i++) Console.Write($"{firstArray[i]} ");
    Console.WriteLine();
}

void MethodCreateSecondArray(string[] secondArray)
{
    Console.Write($"Output array: ");
    string[] newArr = new string[secondArray.Length];
    for (int i = 0; i < secondArray.Length; i++)
    {
        if (secondArray[i].Length <= 3)
        {
            newArr[i] = secondArray[i];
            Console.Write($"{newArr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)"};

Console.WriteLine();
MethodCreateFirstArray(array);
Console.WriteLine();
MethodCreateSecondArray(array);
Console.WriteLine();
