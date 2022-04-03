// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

Console.Clear();

int a = 0;
// возьми эту переменную. это будет важно потом

int SizeOfArray(int c)
{
    Console.Clear();
    int size = 0;
// это у нас "высота" рамки, или, если быть точнее, количество строк двумерного массива
    if (c == 0)
    {
        Console.WriteLine("Put a frame height");
        size = Convert.ToInt32(Console.ReadLine());
    }
// а это "ширина" рамки, которая поможет найти количество столбцов в двумерном массиве,
// который в последствии нарисует нам рамку из единиц, которая является нашей задачей, 
// которая входит в курс обученья c#(сишарп),
// который на ресурсе geekbrains расположен,
// который готовит специалистов хороших,
// которые будут улучшать жизнь на планете,
// в мире который построил ...
    else
    {
        Console.WriteLine("Put a frame width");
        size = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}
void Ramka(int[,] matrix)
{
    Console.Clear();
    Console.WriteLine($"Frame [{matrix.GetLength(0)}, {matrix.GetLength(1)}] now appeared:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // if (matrix[i,j] == 0)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // здесь рассматриваем элементы первого и последнего столбцов и если значения не нулевые => пишем 1
            if (((j == 0) || (j == matrix.GetLength(1) - 1)) && (matrix[i, j] != 1))
            {
                matrix[i, j] = 1;
                Console.Write($"{matrix[i, j]} ");
            }
            // то же самое что выше, но для первой и последней строчки
            if (((i == 0) || (i == matrix.GetLength(0) - 1)) && (matrix[i, j] == 0))
            {
                matrix[i, j] = 1;
                Console.Write($"{matrix[i, j]} ");
            }
            // иначе значение элемента массива = 0
            else if ((i > 0 && i < matrix.GetLength(0) - 1) && (j > 0 && j < matrix.GetLength(1) - 1))
            {
                matrix[i, j] = 0;
                Console.Write($"{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
// в методе мы возвращаем значение длины двумерного массива два раза(a, a+1)*: 
// первый для количества "колонок" и второй для количества "строк"
// *переменная "a" используется просто как тумблер для перехода на другой уровень в методе

int[,] array = new int[SizeOfArray(a), SizeOfArray(a + 1)];   
Ramka(array);

