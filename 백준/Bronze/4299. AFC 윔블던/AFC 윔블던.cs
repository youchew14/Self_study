string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int[] re = new int[num.Length];

re[0] = Math.Abs((num[0] + num[1]) / 2);
re[1] = Math.Abs((num[0] - num[1]) / 2);

if (re[0] + re[1] == num[0] && re[0] - re[1] == num[1])
{
    if (re[0] > re[1])
    {
        Console.WriteLine("{0} {1}", re[0], re[1]);
    }
    else
    {
        Console.WriteLine("{0} {1}", re[1], re[0]);
    }
}
else
{
    Console.WriteLine(-1);
}