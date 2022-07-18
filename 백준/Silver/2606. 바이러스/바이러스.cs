int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[,] node = new int[n + 1, n + 1];
int[] visi = new int[n + 1];

Queue<int> q = new Queue<int>();

for (int i = 0; i < m; i++)
{
    int[] nn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    node[nn[0], nn[1]] = 1;
    node[nn[1], nn[0]] = 1;
}

q.Enqueue(1);
visi[1] = 1;
int c = 0;

while (q.Count != 0)
{
    int x = q.Dequeue();

    for(int k = 1; k < node.GetLength(0); k++)
    {
        if (node[x, k] == 1 && visi[k] != 1)
        {
            q.Enqueue(k);
            visi[k] = 1;
            c++;
        }
    }
}
Console.WriteLine(c);