string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int re = Math.Abs(num[0] - num[2]);
int n = num[2];

for (int i = num[1]; i < num[2] + 1; i++)
{
    int m = Math.Abs(num[0] - i);
    if (m < re)
    {
        re = m;
        n = i;
    }
}
Console.WriteLine(n);