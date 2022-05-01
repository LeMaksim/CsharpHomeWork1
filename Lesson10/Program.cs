// Задача: Заданы 2 массива: info и data. В массиве data хранятся двоичные представления нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, 
// которые занимают числа из массива data. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

Start:
Console.WriteLine("Enter a subsequence of 0 and 1.\nEnter any other NUMBER to complete binary array");
// для начала, все числа вводимые пользователем с консоли, мы записываем в спимок preData.
List<string> preData = new List<string>();
string str = "";
int sum = 0, num = 0, k = 0;

// так как мы не знаем, сколько чисел введет пользователь, инициализируем бесконечный цикл while(true){}.
while (true)
{
    // try чтоб по нажатию буквы или не числового символа не выскакивал форматэксепшн.
    try
    {
        str = Console.ReadLine();
    // TryParse чтоб по нажатию ENTER не выскакивал форматэксепшн.
    if ((int.TryParse(str, out num)) & (int.Parse(str) != 0 && int.Parse(str) != 1)) break;
    else preData.Add(str);
    }
    catch (System.FormatException)
    {
        if (preData.Count == 0) {Console.Clear(); Console.WriteLine("Whoops, looks like we got naughty guy over here! Try again and enter valid values."); Console.ReadKey(); goto Start;}
        break;
    }
    
}
Console.Clear();

// теперь создаем список, чтоб бесконечно(почти) принимать данные о количестве бит, которые занимают числа из массива data.
List<int> preInfo = new List<int>();
Console.WriteLine("Enter amount of bits up to 8 to divide binary array. \nTo avoid missunderstanding -- enter valid positive integer numbers.\nBecause you can't take couple of negative bits.\nAnd rational ones. And real ones.\nI hope we understand each other.");
while (true)
{
    // снова обработка исключений.
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0 && num <= 8)
        {
            preInfo.Add(num);
            // переменная для подсчета общего количества бит в массиве info. 
            sum = 0;
            for (int i = 0; i < preInfo.Count; i++)
            {
                sum = sum + preInfo[i];
            }
            // сравниваем количество бит с количеством цифр массива data. если битов получилось больше, то дополняем массив data нулями.
            //  если битов ровно, то мы пытаемся заполнить нулями, цикл пропустит это, так как preData.Count == sum и мы избегаем просьбы программы ввести ещё число(сверх необходимого) 
            if (sum >= preData.Count)
            {
                for (int i = preData.Count; i < sum; i++)
                {
                    preData.Add("0");
                }
                break;
            }
        }
        else break;
    }
    catch (System.FormatException)
    {
        break;
    }

}
Console.Clear();
// наконец добрались до главного - инициализаии и заполнения массива data...если бы речь шла о строках, коллекциях, а не массивах, то решалась бы задача быстрее
// по крайней мере мне так показалось, пока я мучался с ней).
string[] data = new string[preData.Count];
Console.Write("data = { ");
for (int i = 0; i < data.Length; i++)
{
    data[i] = preData[i];
    Console.Write(data[i] + " ");
}
Console.Write("}\n");
// инициализируем и заполняем массив info.
int[] info = new int[preInfo.Count];
Console.Write("info = { ");
for (int i = 0; i < info.Length; i++)
{
    info[i] = preInfo[i];
    Console.Write(info[i] + " ");
}
Console.Write("}\n");
// инициализируем и заполнем выходной массив.
int[] deci = new int[info.Length];

for (int i = 0; i < info.Length; i++)
{
    // я решил преобразовать через строки.
    // инициализируем пустую строку.
    string binary = string.Empty;
    // программа берет каждый элемент(формально количество бит) для репрезентации десятичного представления двоичного числа из массива data.
    // переменная k "запоминает" где мы остановились при формировании строки binary.
    for (int j = 0; j < info[i]; j++, k++)
    {
        binary = binary + data[k];
    }
    deci[i] = Convert.ToInt32(binary, 2);
}
Console.Write("{ ");
foreach (var item in deci)
{
    Console.Write(item + " ");
}
Console.Write("}\n");