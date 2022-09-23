// Полиандром или нет

Console.WriteLine("Введите пятизначное число -> ");
string str = Console.ReadLine();

if ((str.Length > 5) || (str.Length < 5))
{
    Console.WriteLine("Число должно быть ПЯТИЗНАЧНЫМ !!!");
    return;
}

char[] ch = str.ToCharArray();

if ((ch[0] == ch[4]) && (ch[1]) == ch[3])
    Console.WriteLine($"{str} -> Полиандром");
else
    Console.WriteLine($"{str} -> Не Полиандром");
