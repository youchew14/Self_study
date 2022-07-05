string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int re = num[0] * num[1];
re -= num[2];

if (re < 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(re);
}