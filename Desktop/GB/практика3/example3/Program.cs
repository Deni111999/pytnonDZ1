//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("введите X и Y для точки A");
string xy = Console.ReadLine()!;
string[] parts = xy.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);

Console.WriteLine("введите X и Y для точки B");
xy = Console.ReadLine()!;
parts = xy.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + (Math.Pow(yA - yB, 2)));
Console.WriteLine($"Расстояние между 2 точками  {distance:F3}");
