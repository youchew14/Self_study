long d = long.Parse(Console.ReadLine());
double re = d * 0.01 + 25;

if (re >= 100 && re <= 2000)
{
    Console.WriteLine("{0:F2}", re);
}
else if (re < 100)
{
    Console.WriteLine(100.00);
}
else
{
    Console.WriteLine(2000.00);
}