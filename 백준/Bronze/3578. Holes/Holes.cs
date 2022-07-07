int user = int.Parse(Console.ReadLine());

if (user == 0)
{
    Console.WriteLine(1);
}
else if (user == 1)
{
    Console.WriteLine(0);
}
else if (user % 2 != 0)
{
    Console.Write(4);
}
if (user - (user % 2) != 0)
{
    for (int i = 0; i < user / 2; i++)
    {
        Console.Write(8);
    }
}