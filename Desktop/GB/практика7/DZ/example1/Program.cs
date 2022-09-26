// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] DoubleArray()
{
    Console.Write("Введите число строк массива m: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите число cтолбцов массива n: ");
    int n = int.Parse(Console.ReadLine()!);
    double[,] array = new double[m, n];
    Random rand = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 11) * rand.NextDouble(), 1);
        }

    }
    return array;
}

void PrintDoubleArray(double[,] prar)
{
    for (int i = 0; i < prar.GetLength(0); i++)
    {
        for (int j = 0; j < prar.GetLength(1); j++)
        {
            Console.Write(prar[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


double[,] array = DoubleArray();
PrintDoubleArray(array);

