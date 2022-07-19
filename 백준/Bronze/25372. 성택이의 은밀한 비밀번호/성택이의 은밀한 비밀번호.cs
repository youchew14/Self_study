StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());

while(n-- > 0)
{
    string pss = sr.ReadLine();

    if (pss.Length <= 9 && pss.Length >= 6) sw.WriteLine("yes");
    else sw.WriteLine("no");
}
sr.Close();
sw.Close();