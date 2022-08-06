StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(Console.ReadLine());
List<int> sum = new List<int>();

while (n-- > 0)
{
    int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Array.Sort(num);

    if (num[0] == num[1] && num[1] == num[2])
    {
        sum.Add(10000 + num[0] * 1000);
    }
    else if (num[0] == num[1] || num[1] == num[2])
    {
        sum.Add(1000 + num[1] * 100);
    }
    else if (num[0] == num[2])
    {
        sum.Add(1000 + num[0] * 100);
    }
    else
    {
        sum.Add(Math.Max(num[0], Math.Max(num[1], num[2])) * 100);
    }
}
sum.Sort();
sw.WriteLine(sum[sum.Count - 1]);
sw.Close();