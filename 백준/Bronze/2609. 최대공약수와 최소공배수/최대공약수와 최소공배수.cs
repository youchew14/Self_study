string[] user = Console.ReadLine().Split(' ');
int[] n = Array.ConvertAll(user, int.Parse);
int m = n[0];
int mm = n[1];

while(n[1] != 0)
{
    int d = 0;

    d = n[0] % n[1];
    n[0] = n[1];
    n[1] = d;
}

Console.WriteLine(n[0]);
Console.WriteLine(m * mm / n[0]);