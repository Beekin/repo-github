Console.WriteLine("Введите имя пользователя");

string username = Console.ReadLine();

if (username.ToLower == "Маша")
{
    Console.WriteLine("Ура Ура, наконец то Маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}