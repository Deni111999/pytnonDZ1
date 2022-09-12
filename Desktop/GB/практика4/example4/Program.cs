// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] CreateArray(int size)
{
    int[] numBol = new int[size];

    for (int i = 0; i < size; i++)
    {
        numBol[i] = new Random().Next(0, 2);
        
    }
    return numBol;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    foreach (int element in array)
    {
        Console.Write($"{element},");
    }
    Console.WriteLine("]");
}
PrintArray(CreateArray(8));
