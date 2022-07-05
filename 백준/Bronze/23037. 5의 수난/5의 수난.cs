using System.Numerics;

string user = Console.ReadLine();
int[] n = new int[user.Length];
BigInteger sum = 0;

for (int i = 0; i < n.Length; i++)
{
    n[i] = int.Parse(user[i].ToString());
    BigInteger re = 1;

    for (int j = 0; j < 5; j++)
    {
        re *= n[i];
    }
    sum += re;
}
Console.WriteLine(sum);