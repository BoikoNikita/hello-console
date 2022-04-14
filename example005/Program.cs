Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "пипетка")
    Console.WriteLine("Ура, это же Пипетка!");
else
    Console.Write("Привет, ");
    Console.WriteLine(username);