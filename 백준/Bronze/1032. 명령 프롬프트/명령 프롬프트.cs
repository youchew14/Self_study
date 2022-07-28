StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
string[] s = new string[n];
string re = null;

for (int i = 0; i < n; i++)
{
    s[i] = Console.ReadLine();
}
for (int i = 0; i < s[0].Length; i++)
{
    string nu = null;

    for (int j = 1; j < n; j++)
    {
        if (s[0][i] != s[j][i])
        {
            nu += '?';
            break;
        }
    }
    if (nu == null)
    {
        nu = s[0][i].ToString();
    }
    re += nu;
}
sw.WriteLine(re);
sw.Close();