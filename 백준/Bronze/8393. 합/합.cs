int n = int.Parse(Console.ReadLine());
int max = 0;

for (int i = 1; i < n+1; i++)
{
    max = max + i;
}

Console.WriteLine(max);