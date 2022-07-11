int a = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int t = int.Parse(Console.ReadLine());

int m1 = 0;
int m2 = 0;

if (t > 30)
{
    m1 = (t - 30) * x;
}
if (t > 45)
{
    m2 = (t - 45) * y;
}
Console.WriteLine("{0} {1}", m1 * 21 + a , m2 * 21 + b);