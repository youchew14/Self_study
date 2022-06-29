using System.Numerics;

string[] sPrice = Console.ReadLine().Split();
BigInteger[] price = new BigInteger[sPrice.Length];

for (int i = 0; i < sPrice.Length; i++)
{
    price[i] = BigInteger.Parse(sPrice[i]);
}
Console.WriteLine(price[0] / price[1]);
Console.WriteLine(price[0] % price[1]);