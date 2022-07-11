string s = Console.ReadLine();
if (s.Length < 100 && s.Length > 10)
{
    while (true)
    {
        Console.WriteLine(s[..10]);

        s = s.Remove(0, 10).ToString();

        if (s.Length <= 10) break;
    }
    Console.WriteLine(s);
}
else
{
    Console.WriteLine(s);
}