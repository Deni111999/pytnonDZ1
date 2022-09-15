// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
const int Size = 12;
int[] numbers = new int[Size];

for (int i = 0; i < Size; i++)
{
    numbers[i] = new Random().Next(-9, 10);
}

int positivesSum = 0;
int negativesSum = 0;

foreach (int number in numbers)
{
    if (number > 0)
        positivesSum += number;
}

foreach (int number in numbers)
{
     if (number < 0)
        negativesSum += number;
}
Console.WriteLine($"сумма положительных={positivesSum},сумма отрицательных={negativesSum}");