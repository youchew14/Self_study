string[] user = Console.ReadLine().Split(' ');
long[] num = Array.ConvertAll(user, long.Parse);

if (num[0] % 2 == 0 || num[1] % 2 == 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(Math.Min(num[0], num[1]));
}