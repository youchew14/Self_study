int[] n = new int[9];
int max = 0;
int position = 0;

for (int i = 0; i < n.Length; i++)
{
    int len = int.Parse(Console.ReadLine());
    n[i] = len;

    if (max < n[i])
    {
        max = n[i];
        position = i+1;
    }
}
Console.Write(max + "\n" + position);