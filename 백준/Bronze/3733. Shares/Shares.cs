while (true)
{
    string user = Console.ReadLine();

    if (user == null)
    {
        break;
    }
    string[] re = user.Split();
    int n = int.Parse(re[0]);
    int s = int.Parse(re[1]);
    int num = s / (n + 1);

    if (n >= s)
    {
        num = 0;
    }
    Console.WriteLine(num);
}
