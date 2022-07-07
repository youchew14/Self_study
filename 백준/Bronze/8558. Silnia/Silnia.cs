using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger sum = 1;

for (int i = 0; i < n; i++)
{
    sum *= i + 1;
}
string nn = sum.ToString();
Console.WriteLine(nn[nn.Length - 1] - '0');