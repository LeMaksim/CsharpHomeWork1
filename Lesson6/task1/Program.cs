// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
int count = 0;
Console.WriteLine("Enter numbers. To complete type somthing. Literally.");
for (; ; ) try
    {
        double number = Convert.ToDouble(Console.ReadLine());
        if (number > 0) count++;
    }
    catch (FormatException)
    {
        Console.WriteLine($"Amount of numbers above zero is {count}");
        break;
    }
