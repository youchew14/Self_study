string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int a = 0;
int b = 0;
int c = 0;

if (7000 * num[1] <= 1000 * num[0])
{
    a = 7000 * num[1];
}
if (3500 * num[1] <= 1000 * num[0])
{ 
    b = 3500 * num[1];
}
if (1750 * num[1] <= 1000 * num[0])
{
    c = 1750 * num[1];
}
Console.WriteLine(Math.Max(a, Math.Max(b, c)));