// Урок 1. Задача 5. Приветствие 
Console.Write("Введите имя пользватля: ");
string username = Console.ReadLine();

if (username.ToLower == "Маша")
{
    Console.WriteLine("Ура, это же Маша");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
