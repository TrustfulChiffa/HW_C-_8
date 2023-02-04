// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int lines, int columns)
{
    int[,] array = new int[lines, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(String.Empty);
    }
    Console.WriteLine(String.Empty);
}

int[] ArrayOfRowSums(int[,] array)
{
    int[] sums = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sums[i] = sum;
    }
    return sums;
}

int MinimumElementIndex(int[] array)
{
    int indexOfMin = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[indexOfMin] > array[i])
        {
            indexOfMin = i;
        }
    }
    return indexOfMin;
}

int lines = 3;
int columns = 3;
int[,] array = CreateArray(lines, columns);

Console.Clear();

Console.WriteLine("Задан массив:");
PrintArray(array);

int[] sums = ArrayOfRowSums(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinimumElementIndex(sums) + 1} строка");
