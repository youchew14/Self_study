int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] words = Console.ReadLine().Split();
    int nn = int.Parse(words[0]);
    for (int k = 0; k < words[1].Length; k++)
    {
        for (int j = 0; j < nn; j++)
        {
            Console.Write(words[1][k]);
        }
    }
    Console.WriteLine();
}