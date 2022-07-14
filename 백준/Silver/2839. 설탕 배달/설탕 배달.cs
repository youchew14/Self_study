int n = int.Parse(Console.ReadLine());
int c = 0;

while(n >= 0)
{
    if (n % 5 == 0)
    {
        c += (int)(n / 5);
        break;
    }
    n -= 3;
    c++;
}
if(n >= 0)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine(-1);
}