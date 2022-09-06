Console.Write("Введи номер дня недели");
string firstNum = Console.ReadLine();
int num1 = int.Parse(firstNum);
if (num1 == 6 || num1 == 7)
        Console.WriteLine("сегодня выходной");
else
        Console.WriteLine("сегодня будни");


