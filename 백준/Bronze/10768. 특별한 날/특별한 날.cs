int m = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

string[] s = { "Before", "After", "Special" };

if (m == 2 && d == 18)
{
    Console.WriteLine(s[2]);
}
else if (m == 2 && d <= 18)
{
    Console.WriteLine(s[0]);
}
else if (m >= 2)
{
    Console.WriteLine(s[1]);
}
else
{
    Console.WriteLine(s[0]);
}