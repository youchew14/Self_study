using System.Numerics;

while(true)
{
    string s = Console.ReadLine();
    if (s == null) break;

    int n = int.Parse(s);
    BigInteger sum = 0;

    for (int i = 0; i < n; i++)
    {
        sum += BigInteger.Parse(Console.ReadLine());
    }
    if (sum == 0)
    {
        Console.WriteLine(0);
    }
    else if (sum > 0)
    {
        Console.WriteLine("+");
    }
    else
    {
        Console.WriteLine("-");
    }
}