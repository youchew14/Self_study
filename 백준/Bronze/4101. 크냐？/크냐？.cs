while(true)
{

    string[] user = Console.ReadLine().Split();
    int a = int.Parse(user[0]);
    int b = int.Parse(user[1]);

    if (a == 0 && b == 0)
    {
        break;
    }
    else if (a < b || a == b)
    {
        Console.WriteLine("No");
    }
    else if (b < a)
    {
        Console.WriteLine("Yes");
    }
}