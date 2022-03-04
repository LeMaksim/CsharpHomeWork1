/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
async void Palindrom(int number)
{
    string pal = Convert.ToString(number);
    int size = pal.Length;
    int count1 = 0;
    int count2 = size;
    while (count1 <= size / 2)
    {
        if (((Math.Truncate(number / Math.Pow(10, count2 - 1)) % 10)) != ((Math.Truncate(number / Math.Pow(10, count1)) % 10)))
        {
            Console.WriteLine($"{number} is not a palindrome");
            break;
        }

        else if ((((Math.Truncate(number / Math.Pow(10, count2 - 1)) % 10)) == ((Math.Truncate(number / Math.Pow(10, count1)) % 10))) && (count1 <= size / 2) && (count2 - count1 > 1))
        {
            count1++;
            count2--;
        }
        else
        {
            Console.WriteLine($"{number} is palindrome");
            break;
        }
    }
}
int a = 14212, b = 12821, c = 23432;

Palindrom(a);
Palindrom(b);
Palindrom(c);
