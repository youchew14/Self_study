int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    for (int j = 2 * n - 2 * i; j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
for (int i = n - 1; i > 0; i--)
{
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    for (int j = 2 * n - 2 * i; j > 0; j--)
    {
        Console.Write(" ");
    }
    for (int j = i; j > 0; j--)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}