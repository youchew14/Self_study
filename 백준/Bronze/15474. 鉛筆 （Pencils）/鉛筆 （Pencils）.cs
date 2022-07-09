string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int a = 0;
int b = 0;
int n = 0;
int m = 0;

while(true)
{

    if (num[0] > n)
    {
        a++;
        n += num[1];
    }
    if (num[0] > m)
    {
        b++;
        m += num[3];
    }
    if (num[0] <= n && num[0] <= m) break;
}
int re = Math.Min((num[2] * a),(num[4] * b));

Console.WriteLine(re);