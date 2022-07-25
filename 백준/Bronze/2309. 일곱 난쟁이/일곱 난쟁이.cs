StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] k = new int[9];

for (int i = 0; i < k.Length; i++)
{
    k[i] = int.Parse(Console.ReadLine());
}
int sum = k.Sum();
int a = 0;
int b = 0;

// 2명을 제외한 나머지의 요소들의 합
for (int i = 0; i < k.Length - 1; i++)
{
    for (int j = i + 1; j < k.Length; j++)
    {
        if (sum - (k[i] + k[j]) == 100)
        {
            a = i;
            b = j;
            break;
        }
    }
}
k[a] = -1;
k[b] = -1;

Array.Sort(k);
for (int i = 2; i < k.Length; i++)
{
    sw.WriteLine(k[i]);
}
sw.Close();