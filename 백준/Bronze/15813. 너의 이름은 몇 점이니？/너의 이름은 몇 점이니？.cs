StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
string name = Console.ReadLine();

int re = 0;

for (int i = 0; i < n; i++)
{
    re += name[i] - 'A' + 1;
}
sw.WriteLine(re);
sw.Close();