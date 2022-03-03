/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
void Method(string number)
{

    int size = number.Length;
    int count = 0;
    int[] num = new int[size];
    while (size > 0)
    {
        num[count] = Convert.ToInt32(number) / (int)Math.Pow(10, Convert.ToInt32(size - count - 1));
        if (size <= 2 || count == 2)
        {
            break;
        } 
        else
        {
            count++;
        }
    }
    if (size >= 3)
    {
        Console.WriteLine(num[2] % 10);
    }
    else
    {
        Console.WriteLine("There is no 3rd digit");
    }
}

Console.WriteLine("Enter a number");
string n1 = Convert.ToString(Console.ReadLine());

Method(n1);