Console.WriteLine("введите 2 числа");
string firstNum = Console.ReadLine();
string secondNum = Console.ReadLine();
var num1 = double.Parse(firstNum);
var num2 = double.Parse(secondNum);
if (num1 * num1 == num2)
{
    Console.WriteLine($"{num1} квадратный корень числа {num2}");
}
else if (num2 * num2 == num1)
{
    Console.WriteLine($"{num2} квадратный корень числа {num1}");
}
else
{
    Console.WriteLine("Числа не являются квадратом друг друга");

}



