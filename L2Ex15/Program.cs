/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
string[] week = new string[] {"Monday", "Thuesday", "Wedensday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("Enter day");
int day = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(week[day-1]);
if (day < 6)
{
    Console.WriteLine("It's workday :(");
}
else
{
    Console.WriteLine("IT'S WEEKEND!");
}