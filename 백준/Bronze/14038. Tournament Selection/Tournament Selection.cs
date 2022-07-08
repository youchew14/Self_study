int count = 0;
string wl = null;

for (int i = 0; i < 6; i++)
{
    wl = Console.ReadLine();
    if (wl == "W")
    {
        count++;
    }
}
if (count >= 5)
{
    Console.WriteLine(1);
}
else if (count >= 3)
{
    Console.WriteLine(2);
}
else if (count >= 1)
{
    Console.WriteLine(3);
}
else
{
    Console.WriteLine(-1);
}