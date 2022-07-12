string[] a = Console.ReadLine().Split(' ');
int[] an = Array.ConvertAll(a, int.Parse);

string[] b = Console.ReadLine().Split(' ');
int[] bn = Array.ConvertAll(b, int.Parse);

string[] c = Console.ReadLine().Split(' ');
int[] cn = Array.ConvertAll(c, int.Parse);

int x, y = 0;

if (an[0] == bn[0])
{
    x = cn[0];
}
else if (an[0] == cn[0])
{
    x = bn[0];
}
else
{
    x = an[0];
}
if(an[1] == bn[1])
{
    y = cn[1];
}
else if (an[1] == cn[1])
{
    y = bn[1];
}
else
{
    y = an[1];
}
Console.WriteLine("{0} {1}", x, y);