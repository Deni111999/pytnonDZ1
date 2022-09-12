//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.WriteLine("введите число");
int max = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = 1; i <= max; i++)
    sum = sum + i;
Console.WriteLine(sum);
