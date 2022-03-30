// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("How much numbers in array do you want?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();
double max = 0, min = 0;
double[] array = new double[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().NextDouble() + new Random().Next(-30, 30);
    Console.Write(string.Format("{0:0.00}", array[i]));
    Console.Write(" ");
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.WriteLine($"\nDifference between {string.Format("{0:0.00}", min)} and {string.Format("{0:0.00}", max)} is {string.Format("{0:0.00}", (max - min))}");