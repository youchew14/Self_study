using System.Numerics;

string[] user = Console.ReadLine().Split(' ');
BigInteger[] num = Array.ConvertAll(user, BigInteger.Parse);
BigInteger re = 0;

for (int i = 0; i < num.Length; i++)
{
    re += num[i];
}
Console.WriteLine(re);