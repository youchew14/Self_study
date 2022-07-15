int[] w = new int[5];
int max = 0;
int index = 0;

for (int i = 0; i < 5; i++)
{
    int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int sum = 0;
    for (int j = 0; j < 4; j++)
    {
        sum += n[j];
        if (max <= sum)
        {
            max = sum;
            index = i + 1;
        }
    }
    w[i] = sum;
}
//int max = Math.Max(w[0], Math.Max(w[1], Math.Max(w[2], w[3])));

//Console.WriteLine("{0} {1}", Array.IndexOf(w, max) + 1, max);
Console.WriteLine("{0} {1}", index, max);