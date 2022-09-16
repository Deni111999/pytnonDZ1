// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позиц
 Console.WriteLine("введите длину массива");
int l = Convert.ToInt32(Console.ReadLine());
int[] array = new int[l];
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
     if(i % 2 > 0) sum = sum + array[i]; 
}
Console.WriteLine();
Console.WriteLine(sum);
