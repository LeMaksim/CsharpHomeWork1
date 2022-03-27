Console.Clear();

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Do you want to fill massive by yourself?\n Enter 1 for Yes / 0 for No");
int desicion = Convert.ToInt32(Console.ReadLine());
if (desicion == 1)
{
    Console.WriteLine("How much numbers would you prefer to enter?");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] row = new int[length];
    Console.WriteLine($"Enter {length} numbers. No less. No more.");
    for (int i = 0; i < length; i++)
    {
        row[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Clear();
    Console.WriteLine("BEHOLD THE ARRAY YOU HAVE CHOOSE!");
    for (int i = 0; i < length; i++)
    {
        Console.Write(row[i] + " ");
    }
}
if (desicion == 0)
{
    Console.WriteLine("How much numbers would you prefer to fill an array?");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] arra = new int[length];
    Console.Clear();
    Console.WriteLine("BEHOLD THE ARRAY YOU HAVE CHOOSE!");
    for (int i = 0; i < length; i++)
    {
        arra[i] = new Random().Next(1, 30);
        Console.Write(arra[i] + " ");
    }
}