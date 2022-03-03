/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
/*
void Proverka(int n1, int n2, int n3)
{
    if (n1 % n2 == 0 && n1 % n3 == 0)
    {
        Console.WriteLine($"Число {n1} является кратным числам {n2} и {n3}");
    }
    else
    {
        Console.WriteLine($"Число {n1} НЕ является кратным числам {n2} и {n3}");
    }
}

Console.WriteLine("1st number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2nd number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3rd number");
int num3 = Convert.ToInt32(Console.ReadLine());

Proverka (num1, num2, num3);
*/

Console.WriteLine("Enter three-digit number and u ll see it's second digit");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number / 10 % 10);
//number = Convert.ToInt32(number / 10) % 10));

