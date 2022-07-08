string user = Console.ReadLine();
string num = user[0].ToString() + user[1].ToString() + user[2].ToString();

if (num.Contains("555"))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}