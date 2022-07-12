int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 0;
while (n > b)
{
    a += 1;
    b += a;
}
int re = b - n;
int t = 0;
int m = 0;
if (a % 2 == 0)
{
    t = a - re;
    m = re + 1;
}
else
{
    t = re + 1;
    m  = a - re;
}
Console.WriteLine("{0}/{1}",t,m);