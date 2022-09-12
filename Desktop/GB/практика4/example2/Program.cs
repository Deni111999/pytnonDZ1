// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int FindLenght(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        Console.WriteLine(digit);
        num = num / 10;
        sum++;
    }
    return sum;
}
Console.WriteLine("введите N");
bool numB = false;
int num = 0;
while (numB == false)
{
    Console.WriteLine("число должно быть целым");
    numB = int.TryParse(Console.ReadLine()!, out num);
}

Console.WriteLine($"количество цифр в {num}->{FindLenght(num)}");

