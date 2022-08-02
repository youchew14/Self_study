StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

List<int> n = new List<int>();
int i = 0;

while(true)
{
    n.Add(int.Parse(Console.ReadLine()));
    if (n[i] == -1) break;

    i++;
}
sw.WriteLine(n.Sum() + 1);
sw.Close();