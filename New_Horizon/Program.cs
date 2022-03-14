/*
Пользователь вводит целые числа до тех пор, пока не введёт ноль. 
Вывести на экран первые два максимальных и первые два минимальных числа из ряда введенных чисел.
А теперь самое интересное: создавать массивы в процессе решения запрещено.
*/

Console.Clear();

int min1 = 0, min2 = 0,
    max1 = 0, max2 = 0,
    count = 1, tumbler = 0;

Console.WriteLine($"Enter {count} number.");
int number = Convert.ToInt32(Console.ReadLine());
count ++;
max1 = number;
max2 = number;
min1 = number;
min2 = number;

do
{
    int temp = 0;
    Console.WriteLine($"Enter {count} number.");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == 0)
    {
        Console.WriteLine("GAME OVER");
        tumbler = 1;
    }  
    if (number > max2 || (number > max2 && number > max1))
    {
        max1 = number;
    }
    if (number < max1 && count < 3)
    {
        max1 = number;
    }
    if (number < min1)
    {
        min2 = number;
    }
    count++;
    if (max1 > max2)
    {
        temp = max1;
        max1 = max2;
        max2 = temp;
    }
    if (number > max1 && number < max2)
    {
        max1 = number;
    }
    if (min1 > min2)
    {
        temp = min2;
        min2 = min1;
        min1 = temp;
    }
    Console.WriteLine($"{min1}, {min2}, {max1}, {max2}");
} while (tumbler == 0);

Console.WriteLine($"{min1}, {min2}, {max1}, {max2}");