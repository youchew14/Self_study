StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split(" ");

    for (int j = 0; j < s.Length; j++)
    {
        for (int k = s[j].Length - 1; k >= 0; k--)
        {
            sw.Write(s[j][k]);
        }
        sw.Write(" ");
    }
    sw.WriteLine();
}
sw.Close();