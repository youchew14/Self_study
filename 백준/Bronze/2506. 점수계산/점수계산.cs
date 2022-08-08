StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int len = int.Parse(Console.ReadLine());

int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int sum = 0;
int nn = 0;

for (int i = 0; i < len; i++)
{
    if (n[i] == 1)
    {
        nn++;
    }
    else
    {
        nn = 0;
    }
    sum += nn;
}
sw.WriteLine(sum);
sw.Close();