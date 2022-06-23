string[] user = Console.ReadLine().Split();
int h = int.Parse(user[0]);
int m = int.Parse(user[1]);

if ( m > 44 )
{
    Console.Write(h + " ");
    Console.Write(m - 45);
} else if ( m < 45 && h > 0)
{
    Console.Write(h - 1 + " ");
    Console.Write(m + 15);
} else
{
    Console.Write(23 + " ");
    Console.Write(m + 15);
}