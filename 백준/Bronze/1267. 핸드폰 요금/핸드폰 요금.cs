StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());

int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Y = 0;
int M = 0;
for (int i = 0; i < n; i++)
{
    Y += (int)Math.Truncate((double)s[i] / 30) * 10 + 10;
    M += (int)Math.Truncate((double)s[i] / 60) * 15 + 15;
}
if (Y < M)
{
    sw.WriteLine("Y {0}", Y);
}
else if (Y > M)
{
    sw.WriteLine("M {0}", M);
}
else
{
    sw.WriteLine("Y M {0}", Y);
}
sw.Close();