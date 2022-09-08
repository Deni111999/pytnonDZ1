//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число n");
string num = Console.ReadLine();
int n = int.Parse(num);
int[] numbers = new int[n];
for (int i = 1; i <= n; i++)
    numbers[i - 1] = i * i* i;

for (int i = 0; i < n; i++)
    Console.WriteLine(numbers[i]);