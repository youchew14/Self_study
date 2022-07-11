int user = int.Parse(Console.ReadLine());

while (true)
{
    string[] hwn = Console.ReadLine().Split(' ');
    int[] num = Array.ConvertAll(hwn, int.Parse);

    int n = int.Parse(Math.Truncate((double)num[2] / (double)num[0] + 1).ToString());
    int f = num[2] % num[0];
    if (num[2] % num[0] == 0)
    {
        n = int.Parse(Math.Truncate((double)num[2] / (double)num[0]).ToString());
        f = num[0];
    }
    Console.WriteLine("{0}", f * 100 + n);

    user--;
    if (user == 0) break;
}