StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int m = int.Parse(sr.ReadLine());

while(m-- > 0)
{
    int[] n = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    int r = ((n[0] % 2 == 0) ? 1 : 0) + ((n[1] % 2 == 0) ? 1 : 0) + ((n[2] % 2 == 0) ? 1 : 0);

    sw.WriteLine((r >= 2) ? "R" : "B");
}

sr.Close();
sw.Close();