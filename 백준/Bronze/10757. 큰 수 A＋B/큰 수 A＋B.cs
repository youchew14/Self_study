using System.Numerics;

string[] user = Console.ReadLine().Split();

BigInteger a = BigInteger.Parse(user[0]);
BigInteger b = BigInteger.Parse(user[1]);

Console.WriteLine(a + b);