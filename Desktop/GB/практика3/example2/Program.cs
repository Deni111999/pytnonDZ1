//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("введите четверть 1 , 2 ,3 , 4");
int quarter = int.Parse(Console.ReadLine()!);

if (quarter == 1)
    Console.WriteLine(" ваш диапазон чисел x > 0 и y > 0");
else if (quarter == 2)
    Console.WriteLine("ваш дипазон чисел x < 0 и y > 0");
else if (quarter == 3)
    Console.WriteLine("ваш диапазон чисел x < 0 и  y < 0");
else if (quarter == 4)
    Console.WriteLine("ваш диапазон чисел x > 0 и y < 0");
else
    Console.WriteLine("Смотри условия ввода!");
