// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                product[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return product;
}

int i1 = 3;
int j1 = 2;

int i2 = 2;
int j2 = 3;

if (i1 != j2)
{
    Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы 1 не равно количеству строк матрицы 2");
}

int[,] matr1 = CreateArray(i1, j1);
int[,] matr2 = CreateArray(i2, j2);

PrintArray(matr1);

Console.WriteLine("*");

PrintArray(matr2);

Console.WriteLine("=");

int[,] matrProduct = MatrixProduct(matr1, matr2);

PrintArray(matrProduct);
