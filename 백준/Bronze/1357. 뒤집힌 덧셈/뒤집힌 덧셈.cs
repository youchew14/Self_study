StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string[] s = Console.ReadLine().Split();
string[] stn = new string[s.Length];

for (int j = 0; j < s.Length; j++)
{
    for (int i = s[j].Length - 1; i >= 0; i--)
    {
        stn[j] += s[j][i];
    }
}
int[] re = Array.ConvertAll(stn, int.Parse);
string sum = re.Sum().ToString();
string print = null;

for (int i = sum.Length - 1; i >= 0; i--)
{
    print += sum[i];
}
sw.WriteLine(int.Parse(print));
sw.Close();