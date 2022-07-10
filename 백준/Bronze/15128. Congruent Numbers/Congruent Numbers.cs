string[] user = Console.ReadLine().Split(' ');
long[] num = Array.ConvertAll(user, long.Parse);

bool re = (num[0] * num[2] % (num[1] * num[3] * 2) == 0);

if (re)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}