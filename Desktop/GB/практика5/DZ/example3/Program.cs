// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double min = array[0];
double max = array[0];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным элементом {max - min}");