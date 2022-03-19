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
    if (number == 0)                                            //1. условие, при котором цикл заканчивается, если вводим число 0
    {
        Console.WriteLine("GAME OVER");
        tumbler = 1;
        break;
    }  
    if (number > max2 || (number > max2 && number > max1))      //2. проверяем условие, чтобы в дальшейшем(8) поменять местами max1 и max2 в случае, если max1 окажется больше max2.
    {
        max1 = number;
    }
    if (number < max1 && count < 3)                             //3. если вводят 2 числа, то необходимо каждое положить в переменную, а в дальнейшем определить кто кого больше/меньше.
    {
        max1 = number;
    }
    if (number < min1)                                          //4. то же самое что во втором условии: сравниваем с минимальным числом и, если условие true, в дальнейшем(9) меняем min1 и min2. 
    {
        min2 = number;
    }
     if (number > min1 && number >= min2 && count < 3)           //7. если вводят 2 числа, то необходимо каждое положить в переменную, а затем определить кто кого больше/меньше
    {
        min2 = number;
    }
    count++;                                                    //5. здесь заканчивается часть цикла, где мы "внутренним"/"ближним" переменным присваиваем "обратные значения", чтобы впоследствии поменять их местами
                                                                // нужно мне это для того, чтобы на каждой иттерации цикла класть переменную во временный буфер, не создавая дополнительные условия сравнения.
    if (number > max1 && number <= max2)                        //6. условие, которое выполняется, если не выполняется условие №2, тогда в дальнейшем мы не меняем местами max1 и max2 
    {
        max1 = number;
    }
    if (max1 > max2)                                            //8. условие сравнения и перестановки max
    {
        temp = max1;
        max1 = max2;
        max2 = temp;
    }
    if (min1 > min2)                                            //9. условие сравнения и перестановки min
    {
        temp = min2;
        min2 = min1;
        min1 = temp;
    }
    //Console.WriteLine($"{min1}, {min2}, {max1}, {max2}");     //10. проверка, куда падает число на каждой иттерации
} while (tumbler == 0);

Console.WriteLine($"First minimun is {min1}, and the second one is {min2}");
Console.WriteLine($"First maximum is {max1}, the second one is  {max2}");