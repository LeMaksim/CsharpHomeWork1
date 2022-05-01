﻿Console.Clear();
Console.WriteLine("Введите количество строк треугольника Паскаля: ");

int n = Convert.ToInt32(Console.ReadLine());


int[][] triangle = new int[n][];
// первая строка
triangle[0] = new int[] { 1 };
// остальные строки
for (int i = 1; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            triangle[i][j] = 1;
        else
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
}
for (int i = 0; i < triangle.Length; i++)
{
    // сначала ставим пробелы
    for (int k = 0; k < triangle.Length - i; k++)
    {
        // количество пробелов перед первым символом каждой строки равно трехкратной разности длины массива и номера строки
        // так, каждая следующая строка будет на 3 пробела ближе к левому краю 
        for (int d = 0; d < 3; d++)
        {
            Console.Write(" ");
        }
    }
    // здесь уже выводим элементы каждой строки с отступом >= 5
    // занимательный факт: чем больше отступ между символами, тем больший треугольник можно вывести
    // так, при отступе 3, треугольник остается равнобедренным вплоть до 13 строки включительно.
    // однако, при таком отступе (3), необходимо изменить количество пробелов перед первым символом на 1
    // так же, если необходимо центрировать относительно осевого элемента, отступов должно быть нечетное количество 
    for (int j = 0; j < triangle[i].Length; j++)
    {
        Console.Write("{0,-5} ", triangle[i][j]);
    }
    Console.WriteLine();
}