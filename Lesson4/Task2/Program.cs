Console.Clear();

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// При отрицательном числе, старший порядок считается числом отрицательным.

Console.WriteLine("Enter the number");
string str = Console.ReadLine();
int len = Convert.ToInt32(str.Length);
int count = 0;
int num = Convert.ToInt32(str);
if (num > 0)
    for (int i = 0; i < len; i++)
    {
        count = count + (num % 10);
        num = num / 10;
    }
if (num < 0)
    for (int i = 0; i < len-2; i++)
    {
        count = count + (Math.Abs(num % 10));
        num = num / 10;
    }
    count = count + num % 10;
Console.Clear();
Console.WriteLine($"Summary of digits in {str} is {count}");