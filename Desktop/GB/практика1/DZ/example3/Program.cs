Console.WriteLine("введите число");
string Num = Console.ReadLine();
var num1 = double.Parse(Num);
if (num1 % 2 == 0)
{
    Console.WriteLine("число четное");
}
else Console.WriteLine("число нечетное");

