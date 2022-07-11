while (true)
{
    string[] user = Console.ReadLine().Split(' ');
    int[] num = Array.ConvertAll(user, int.Parse);

    if (num[0] == 0 && num[1] == 0 && num[2] == 0) break;

    Array.Sort(num);
    int re = (int)Math.Pow(num[0], 2) + (int)Math.Pow(num[1], 2);
    if (re == (int)Math.Pow(num[2], 2))
    {
        Console.WriteLine("right");
    }
    else
    {
        Console.WriteLine("wrong");
    }
}