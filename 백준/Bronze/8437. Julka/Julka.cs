using System.Numerics;

BigInteger a = BigInteger.Parse(Console.ReadLine());
BigInteger b = BigInteger.Parse(Console.ReadLine());

BigInteger n = (a / 2) - (b / 2);
BigInteger k = a - n;

Console.WriteLine(k);
Console.WriteLine(n);