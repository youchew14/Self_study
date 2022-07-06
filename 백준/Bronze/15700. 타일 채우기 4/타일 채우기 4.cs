using System.Numerics;

string[] user = Console.ReadLine().Split(' ');
BigInteger[] num = Array.ConvertAll(user, BigInteger.Parse); // N M

Console.WriteLine((num[0] * num[1]) / 2);