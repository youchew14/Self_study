string[] user = Console.ReadLine().Split();
int a = int.Parse(user[0]);

if (a >= 90)
{
    Console.WriteLine("A");
} else if (a >= 80)
{
    Console.WriteLine("B");
} else if (a >= 70)
{
    Console.WriteLine("C");
} else if (a >= 60)
{
    Console.WriteLine("D");
} else
{
    Console.WriteLine("F");
}