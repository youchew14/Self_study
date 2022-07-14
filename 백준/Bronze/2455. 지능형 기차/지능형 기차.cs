int max = 0;
int sum = 0;

for (int k = 0; k < 4; k++)
{
    int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    sum = n[1] - n[0] + sum;

    if (sum > max)
    {
        max = sum;
    }
}
Console.WriteLine(max);