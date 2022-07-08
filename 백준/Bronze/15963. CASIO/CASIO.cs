string[] user = Console.ReadLine().Split(' ');
long[] num = Array.ConvertAll(user, long.Parse);

if (num[0] == num[1])
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}