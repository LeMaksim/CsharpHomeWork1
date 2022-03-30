// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("How much numbers in array do you want?");
int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int sum = 0;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write(array[i] + " ");
    if (i % 2 == 0) sum = sum + array[i];
}
Console.WriteLine($"\nSum of all odd-positioned array elements is {sum} ");