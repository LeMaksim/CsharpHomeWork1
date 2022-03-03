// Задача 1: Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

int a = 5, b = 7;

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

a = 2;
b = 10;

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

a = -9;
b = -3;

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