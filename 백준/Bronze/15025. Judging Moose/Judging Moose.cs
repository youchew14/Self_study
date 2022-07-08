string[] moo = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(moo, int.Parse);

if (num[0] != num[1])
{
    Console.WriteLine("Odd {0}", Math.Max(num[0], num[1]) * 2);
}
else if (num[0] == 0 && num[1] == 0)
{
    Console.WriteLine("Not a moose");
}
else
{
    Console.WriteLine("Even {0}", num[1] * 2);
}