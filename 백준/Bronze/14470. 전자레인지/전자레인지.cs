int[] s = new int[5];
int t = 0;

for (int i = 0; i < 5; i++)
{
    s[i] = int.Parse(Console.ReadLine());
}
while(true)
{
    if (s[0] < 0)
    {
        s[0] += 1;
        t++;
        if (s[0] == 0)
        {
            t *= s[2];
        }
        if (s[0] >= 0)
        {
            t += s[3] + (s[1] * s[4]);
            break;
        }
    }
    if (s[0] > 0)
    {
        int k = s[1] - s[0];
        t = k * s[4];
        break;
    }
}
Console.WriteLine("{0}", t);