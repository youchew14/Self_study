int s = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

int re = (1 * s) + (2 * m) + (3 * l);
if (re >= 10)
{
    Console.WriteLine("happy");
}
else
{
    Console.WriteLine("sad");
}