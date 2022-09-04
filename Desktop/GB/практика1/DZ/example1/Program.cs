Console.WriteLine("введите 2 числа");
string firstNum = Console.ReadLine();
string secondNum = Console.ReadLine();
var num1 = double.Parse(firstNum);
var num2 = double.Parse(secondNum);
if (num1>num2)
{
    Console.WriteLine("первое число болшее а второе меньшее");
}
else Console.WriteLine("второе число большее а первое меньшее");

