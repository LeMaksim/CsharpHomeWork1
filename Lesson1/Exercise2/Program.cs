//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

int[] first = new int[] { 2, 3, 7 };

int count = 0, max = 0;
while (count < first.Length)
{
    if (max < first[count])
    {
        max = first[count];
        count++;
    }
    else
    {
        count++;
    }
}

Console.WriteLine(max);

count = 0;
max = 0;
int[] second = new int[] { 44, 5, 78 };

while (count < second.Length)
{
    if (max < second[count])
    {
        max = second[count];
        count++;
    }
    else
    {
        count++;
    }
}

Console.WriteLine(max);

count = 0;
max = 0;
int[] third = new int[] { 22, 3, 9 };

while (count < third.Length)
{
    if (max < third[count])
    {
        max = third[count];
        count++;
    }
    else
    {
        count++;
    }
}

Console.WriteLine(max);