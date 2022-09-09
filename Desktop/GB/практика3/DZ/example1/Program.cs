// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите 5 значное число");
string number = Console.ReadLine()!;

if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Введите 5значное число");


void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
        Console.WriteLine($"ваше число {number} палидром");

    else
        Console.WriteLine($"ваше число {number} не палледром");
}