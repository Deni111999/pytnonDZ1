Console.WriteLine("ведите трехзначное число и я покажу его вторую цифру");
string num = Console.ReadLine();
int num1 = int.Parse(num);
int digit2 = (num1 / 10) % 10;
Console.Write(digit2);