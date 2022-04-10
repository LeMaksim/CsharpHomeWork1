Console.Clear();
// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("Enter matrix height and width");
// int row = Convert.ToInt32(Console.ReadLine());
// int column = Convert.ToInt32(Console.ReadLine());

int[,] NewIntegerMatrix(int row, int column)
{
    int[,] martix = new int[row, column];
    for (int i = 0; i < martix.GetLength(0); i++)
    {
        for (int j = 0; j < martix.GetLength(1); j++)
        {
            martix[i, j] = new Random().Next(0, 10);
            // Console.Write(martix[i, j] + " ");
        }
        // Console.WriteLine();
    }
    // Console.WriteLine();
    return martix;
}

int[,] Sorting(int[,] matrix)
{
    int[] sort = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sort[i] = matrix[i, 0];
        Console.WriteLine(sort[i]);
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    sort[i] = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = sort[i];
                }
            }
        }
    }
    Console.WriteLine();
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// int[,] unsortedMatrix = NewIntegerMatrix(row, column);
// PrintMatrix(unsortedMatrix);
// Sorting(unsortedMatrix);
// PrintMatrix(unsortedMatrix);
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void MinSumInRow(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum[i] = sum[i] + matrix[i, j];
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write(" " + sum[i]);
        Console.WriteLine();
    }
    int min = sum[0];
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            minRow = i;
        }
    }
    Console.WriteLine(minRow + 1);
}
// int[,] anotherMatrix = NewIntegerMatrix(row,column);
// PrintMatrix(anotherMatrix);
// MinSumInRow(anotherMatrix);


// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void NotRepetetiveParallelepiped()
{
    Console.WriteLine("Enter matrix height, width and depth");
    int row = Convert.ToInt32(Console.ReadLine());
    int column = Convert.ToInt32(Console.ReadLine());
    int depth = Convert.ToInt32(Console.ReadLine());
    int[,,] parallelepipede = new int[row, column, depth];
    int opa = 10;
    for (int i = 0; i < parallelepipede.GetLength(0); i++)
    {
        for (int j = 0; j < parallelepipede.GetLength(1); j++)
        {
            for (int k = 0; k < parallelepipede.GetLength(2); k++)
            {

                parallelepipede[i, j, k] = opa;
                opa++;
                Console.Write($"{parallelepipede[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
NotRepetetiveParallelepiped();

// Задача 4: Заполните спирально массив 4 на 4.
int[,] matrix = new int[4, 4];
int k = 1;
for (int i = 0; i < 4; i++)
{
    matrix[0, i] = k;
    k++;
}
for (int i = 1; i < 4; i++)
{
    matrix[i, 3] = k;
    k++;
}
for (int i = 2; i >= 0; i--)
{
    matrix[3, i] = k;
    k++;
}
for (int i = 2; i > 0; i--)
{
    matrix[i, 0] = k;
    k++;
}
for (int i = 1; i < 3; i++)
{
    matrix[1, i] = k;
    k++;
}
for (int i = 2; i > 0; i--)
{
    matrix[2, i] = k;
    k++;
}
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}