Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "мaша")
{
    Console.WriteLine("Ох уж эта Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
