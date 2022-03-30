// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.WriteLine("How much numbers in array do you want?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int count = 0;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"\nThere are {count} even numbers in array");