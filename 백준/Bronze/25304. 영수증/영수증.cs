long cost = long.Parse(Console.ReadLine());
long num = long.Parse(Console.ReadLine());
long re = 0;

for (int i = 0; i < num; i++)
{
    string[] user = Console.ReadLine().Split(' ');
    long[] user_num = Array.ConvertAll(user, long.Parse);

    re += user_num[0] * user_num[1];
}
if (cost == re)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}