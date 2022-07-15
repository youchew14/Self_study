int[] h = new int[7];
int sum = 0;

for (int i = 0; i < 7; i++)
{
    int n = int.Parse(Console.ReadLine());

    if (n % 2 != 0)
    {
        h[i] = n;
        sum += n;
    }
}
if(sum != 0)
{
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine(-1);
}
Array.Sort(h);
for (int i = 0; i < h.Length; i++)
{
    if(h[i] != 0)
    {
        Console.WriteLine(h[i]);
        break;
    }
}