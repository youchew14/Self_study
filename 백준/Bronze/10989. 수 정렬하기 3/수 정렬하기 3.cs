StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
int[] nn = new int[10001];

for (int i = 0; i < n; i++)
{
    int ll = int.Parse(Console.ReadLine());
    nn[ll]++;
}
for (int i = 0; i < nn.Length; i++)
{
    for(int j = 0; j < nn[i]; j++)
    {
        sw.WriteLine(i);
    }
}
sw.Close();