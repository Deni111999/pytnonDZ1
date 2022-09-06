Console.Write("Введи число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(num1);
if (num.Length > 2){
  Console.WriteLine("третья цифра " + num[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}