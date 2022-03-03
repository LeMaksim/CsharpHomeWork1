//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Do we have even number? ");
int a = 4, b = -3, c = 7;
Console.WriteLine(a);
if (a % 2 == 0)
{
    Console.WriteLine("Yes! This is even number.");
}
else
{
    Console.WriteLine("Sorry, Bro(rio), but your even number is in another place.");

}
Console.WriteLine(b);
if (b % 2 == 0)
{
    Console.WriteLine("Yes! This is even number.");
}
else
{
    Console.WriteLine("Sorry, Bro(rio), but your even number is in another place.");
}
Console.WriteLine(c);
if (c % 2 == 0)
{
    Console.WriteLine("Yes! This is even number.");
}
else
{
    Console.WriteLine("Sorry, Bro(rio), but your even number is in another place.");
}