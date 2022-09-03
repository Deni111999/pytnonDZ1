Console.WriteLine("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
Console.WriteLine("Ура!Это же Маша");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}