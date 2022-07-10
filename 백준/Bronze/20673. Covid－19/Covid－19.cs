int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

if (n <= 50 && m <= 10)
{
    Console.WriteLine("White");
}
else if (m > 30)
{
    Console.WriteLine("Red");
}
else
{
    Console.WriteLine("Yellow");
}