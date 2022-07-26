StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
int[] nn = new int[10001];

while(n-- > 0)
{
    int ll = int.Parse(Console.ReadLine());
    nn[ll]++;
}
for (int i = 0; i < nn.Length; i++)
{
    while(nn[i]-- > 0)
    {
        sw.WriteLine(i);
    }
}
sw.Close();