StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

string[] m = new string[n[0]];
int countC = n[0];
int countR = n[1];

// 행 탐색
for (int i = 0; i < n[0]; i++)
{
    m[i] = Console.ReadLine();
    if (m[i].Contains('X'))
    {
        // X를 포함하고 있으면
        countC--;
    }
}
//열 탐색
for (int i = 0; i < n[1]; i++)
{
    for (int j = 0; j < n[0]; j++)
    {
        if (m[j][i] == 'X')
        {
            countR--;
            break;
        }
    }
}
sw.WriteLine(Math.Max(countC, countR));
sw.Close();