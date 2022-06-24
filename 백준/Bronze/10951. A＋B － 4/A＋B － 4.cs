while (true)
{
    string user = Console.ReadLine();

    if (user == null) break;

    string[] st = user.Split();
    int a = int.Parse(st[0]);
    int b = int.Parse(st[1]);

    Console.WriteLine(a + b);
}