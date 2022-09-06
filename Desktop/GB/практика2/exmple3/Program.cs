Console.WriteLine("ведите 2 числа");
string firstNum = Console.ReadLine();
string secondNum = Console.ReadLine();
int num1 = int.Parse(firstNum);
int num2 = int.Parse(secondNum);
if (num1 % num2 == 0)
    Console.WriteLine("числа являются кратными");
else
{
    int a = (num1 % num2);
    Console.WriteLine($"числы не кратны друг другу остаток от деления {a}");
}




