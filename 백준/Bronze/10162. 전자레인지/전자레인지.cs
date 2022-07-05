int t = int.Parse(Console.ReadLine());

int[] re = { 0, 0, 0 };

if (t % 10 == 0)
{
    if (t >= 300)
    {
        re[0] = t / 300;
        t -= 300 * re[0];
    }
    if (t >= 60)
    {
        re[1] = t / 60;
        t -= 60 * re[1];
    }
    if (t >= 10)
    {
        re[2] = t / 10;
        t -= 10 * re[2];
    }
    Console.WriteLine(string.Join(" ", re));
}
else
{
    Console.WriteLine(-1);
}