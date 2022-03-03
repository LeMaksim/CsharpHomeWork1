// Задача 1: Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

void Proverka(int a, int b)
{
    Console.Write("What number is greater? ");
    Console.Write(a);
    Console.Write(" or ");
    Console.Write(b);
    Console.WriteLine("? ");
    if (a < b)
    {
        Console.Write(b);
        Console.WriteLine(" is greater");
    }
    else
    {
        Console.Write(a);
        Console.WriteLine(" is greater");
    }
}

int a1 = 5, b1 = 7, a2 = 2, b2 = 10, a3 = -9, b3 = -3;

Proverka(a1, b1);
Proverka(a2, b2);
Proverka(a3, b3);