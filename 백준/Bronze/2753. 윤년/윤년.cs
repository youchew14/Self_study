string[] user = Console.ReadLine().Split();
int year = int.Parse(user[0]);

if ((year%4) == 0 && (year%100) != 0 || (year%400) == 0)
{
    Console.WriteLine(1);
} else
{
    Console.WriteLine(0);
} 