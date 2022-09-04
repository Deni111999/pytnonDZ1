Console.WriteLine("введите 3 числа");
string firstNum = Console.ReadLine();
string secondNum = Console.ReadLine();
string thirdNum = Console.ReadLine();
var num1 = double.Parse(firstNum);
var num2 = double.Parse(secondNum);
var num3 = double.Parse(thirdNum);
            
                if (num1 > num2 && num1 > num3)
                    Console.WriteLine("Nubmer Max = " + num1); 
                else if (num2 > num3)
                    Console.WriteLine("Number Max = " + num2); 
                else
                    Console.WriteLine("Number Max = " + num3); 
            
          
