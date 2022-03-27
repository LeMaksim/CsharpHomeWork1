Console.Clear();

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int C = 1;
Console.WriteLine("Enter base of number");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter exponent of number");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < B; i++)
{
    C = C * A;
}
Console.Clear();
Console.WriteLine($"Number {A} to the power of {B} is {C}");