// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] numbers = CreateArray(4);
PrintArray(numbers);
ChangeElements(numbers);
PrintArray(numbers);

int[] CreateArray(int Size)
{
    int[] numbers = new int[Size];

    for (int i = 0; i < Size; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
    }
    return numbers;

}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number}");
    }
    Console.WriteLine();
}

void ChangeElements(int[] numbers)
{   for (int i=0;i<numbers.Length;i++)
    {
        numbers[i]= -numbers[i];
    } 
}