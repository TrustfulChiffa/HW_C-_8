// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] OrderLines(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int max = 0; max < array.GetLength(1) - 1; max++)
            {
                if (array[i, max] < array[i, max + 1])
                {
                    int temp = array[i, max + 1];
                    array[i, max + 1] = array[i, max];
                    array[i, max] = temp;
                }
            }
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

int lines = 3;
int columns = 4;

Console.Clear();

int[,] array = CreateArray(lines, columns);

Console.WriteLine("Исходный массив:");

PrintArray(array);

int[,] orderedArray = OrderLines(array);

Console.WriteLine("Отсортированный массив:");

PrintArray(orderedArray);