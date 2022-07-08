int[] a = new int[3];
int[] b = new int[3];

for (int i = 0; i < 3; i++)
{
    a[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 3; i++)
{
    b[i] = int.Parse(Console.ReadLine());
}
int acount = (a[0] * 3) + (a[1] * 2) + a[2];
int bcount = (b[0] * 3) + (b[1] * 2) + b[2];

if (acount > bcount)
{
    Console.WriteLine("A");
}
else if (acount < bcount)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("T");
}