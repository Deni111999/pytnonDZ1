// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
PrintArray(numbers);

ReverseArray(numbers);
PrintArray(numbers);

void Swap(ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
}

void PrintArray(int[] numbers) => Console.WriteLine(string.Join(",", numbers));

void ReverseArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        Swap(ref numbers[i], ref numbers[^(i + 1)]);
    }
}