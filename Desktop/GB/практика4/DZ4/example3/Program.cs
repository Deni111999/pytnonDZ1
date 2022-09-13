// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
int[] InputArrayElements()  
{ 
    Console.WriteLine("введите элементы массивы через пробел"); 
    string elems = Console.ReadLine()!; 
    string[] elemsSplited = elems.Split(' '); 
    int[] array = new int[elemsSplited.Length]; 
 
    for (int i = 0; i < elemsSplited.Length; i++) 
    { 
        array[i] = int.Parse(elemsSplited[i]); 
    } 
    return array; 
} 
void PrintArray(int[] array) 
{ 
    Console.Write("Ваш массив : "); 
    foreach (int a in array) 
    { 
        Console.Write($" {a}, "); 
    } 
} 
 
int[] arrayTest = InputArrayElements(); 
PrintArray(arrayTest);