string[] user = Console.ReadLine().Split(' ');
bool re = false; // no

if (user[1].Contains("+"))
{
    if (int.Parse(user[0]) + int.Parse(user[2]) == int.Parse(user[4]))
    {
        re = true;
    }
}
else if (user[1].Contains("-"))
{
    if (int.Parse(user[0]) - int.Parse(user[2]) == int.Parse(user[4]))
    {
        re = true;
    }
}
else if (user[1].Contains("*"))
{
    if (int.Parse(user[0]) * int.Parse(user[2]) == int.Parse(user[4]))
    {
        re = true;
    }
}
else if (user[1].Contains("/"))
{
    if (int.Parse(user[0]) / int.Parse(user[2]) == int.Parse(user[4]))
    {
        re = true;
    }
}
if (re)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}