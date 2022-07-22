StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

if (n[1] == 1)
{
    sw.WriteLine(-1);
}
else
{
    double re = Math.Truncate((n[0] * n[1]) / (n[1] - 1));
    if ((n[0] * n[1]) % (n[1] - 1) != 0) re += 1;

    sw.WriteLine(re);
}
sw.Close();