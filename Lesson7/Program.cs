Console.Clear();
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter matrix height and width");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

double[,] NewDoubleMatrix(int row, int column)
{
    double[,] martix = new double[row, column];
    for (int i = 0; i < martix.GetLength(0); i++)
    {
        for (int j = 0; j < martix.GetLength(1); j++)
        {
            martix[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
            Console.Write(martix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return martix;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:0.000} ", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// PrintMatrix(NewMatrix(row, column));

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] NewIntegerMatrix(int row, int column)
{
    int[,] martix = new int[row, column];
    for (int i = 0; i < martix.GetLength(0); i++)
    {
        for (int j = 0; j < martix.GetLength(1); j++)
        {
            martix[i, j] = new Random().Next(0, 10);
            Console.Write(martix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return martix;
}

int ElementReturn(int[,] matrix)
{
    int a = matrix.GetLength(0), b = matrix.GetLength(1);
    Console.WriteLine("Enter element's position(i,j - one by one)");
    int row = Convert.ToInt32(Console.ReadLine());
    int column = Convert.ToInt32(Console.ReadLine());
    if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1))
    {
        Console.Write($"A [{row},{column}] element is ");
        return matrix[row - 1, column - 1];
    }
    else
    {
        Console.WriteLine("There is no inner element");
        return 0;
    }
}

// Console.WriteLine(ElementReturn(NewIntegerMatrix(row, column)));

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Average(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            average[j] = average[j] + matrix[i,j];
        }
    }
    for (int i = 0; i < average.Length; i++)
    {
        Console.Write("{0:0.0} ",average[i]/matrix.GetLength(1));
    }
}
// Average(NewIntegerMatrix(row,column));