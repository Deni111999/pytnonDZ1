Console.WriteLine("ведите  число");
string firstNum = Console.ReadLine();
int num1 = int.Parse(firstNum);
if (num1 % 7 == 0 && num1 % 23 == 0)
    Console.WriteLine("число является кратным 7 и 23");
else
{

    Console.WriteLine("числы не кратно 7 и 23");
}

