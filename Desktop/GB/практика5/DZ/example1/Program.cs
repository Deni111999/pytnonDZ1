//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[Size];
ArrayRandomNumbers(numbers);
Console.WriteLine("рандомный массив: ");
PrintArray(numbers);
int count = 0;

for (int p = 0; p < numbers.Length; p++)
if (numbers[p] % 2 == 0)
count++;

if (numbers.Length <5)
Console.WriteLine($"итого {numbers.Length} числа, {count} из них чётные");
else 
Console.WriteLine($"итого {numbers.Length} чисел, {count} из них чётные");

void ArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}