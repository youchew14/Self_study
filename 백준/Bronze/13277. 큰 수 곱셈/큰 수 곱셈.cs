using System.Numerics;

string[] user = Console.ReadLine().Split(' ');
BigInteger[] num = Array.ConvertAll(user, BigInteger.Parse);
BigInteger a = num[0];
BigInteger b = num[1];

Console.WriteLine(a * b);