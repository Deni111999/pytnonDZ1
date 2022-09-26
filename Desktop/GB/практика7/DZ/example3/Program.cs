// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void ArrayArithmeticMean(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write(array[i, j] +"\t");
        }
        Console.WriteLine(" ");
    }
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double arithmeticMean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmeticMean = arithmeticMean + Math.Abs(array[j, i]);
        }
        arithmeticMean = arithmeticMean / array.GetLength(0);
        Console.WriteLine($"среднее арифмитеское столбца {i} :{arithmeticMean}");
    }
}
Console.WriteLine("введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
ArrayArithmeticMean(m, n);

