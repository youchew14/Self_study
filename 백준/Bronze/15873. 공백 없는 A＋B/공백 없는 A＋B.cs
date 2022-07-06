string user = Console.ReadLine(); // 10 10 >> 20

if (user.Length == 2)
{
    Console.WriteLine(user[0] - '0' + user[1] - '0');
}
else if (user.Length == 3 && user[1] - '0' == 0)
{
    string a = user[0].ToString() + user[1].ToString();
    Console.WriteLine(int.Parse(a) + user[user.Length - 1] - '0');
}
else if (user.Length == 4)
{
    Console.WriteLine(20);
}
else
{
    string b = user[1].ToString() + user[2].ToString();
    Console.WriteLine(int.Parse(b) + user[0] - '0');
}