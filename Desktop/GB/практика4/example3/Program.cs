//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("введите число");
int max = int.Parse(Console.ReadLine()!);

int multiply = 1;
for (int i = 1; i <= max; i++)
    multiply = multiply * i;
Console.WriteLine(multiply);