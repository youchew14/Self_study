int n = int.Parse(Console.ReadLine());

while (true)
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int[] f = new int[b];
    for (int i = 0; i < b; i++)
    {
        f[i] = i + 1;
    }
    for (int i = 0; i < a; i++)
    {
        for (int j = 1; j < b; j++)
        {
            f[j] += f[j - 1];
        }
    }
    Console.WriteLine(f[b - 1]);

    n--;
    if (n == 0) break;
}