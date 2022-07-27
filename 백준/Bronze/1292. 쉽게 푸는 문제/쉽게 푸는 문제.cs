StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] u = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

string[] n = new string[1001];
int k = 1;

for (int i = 0; i < 1001; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (k == 1001) break;
        n[k] = i.ToString();
        k++;
    }
}
int re = 0;
for(int i = u[0]; i <= u[1]; i++)
{
    re += int.Parse(n[i]);
}
sw.WriteLine(re);
sw.Close();