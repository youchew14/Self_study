int user = int.Parse(Console.ReadLine());

if (user%8 >= 1 && user%8 <= 5)
{
    Console.WriteLine(user % 8);
}
else if (user%8 == 6)
{
    Console.WriteLine(4);
}
else if (user%8 == 7)
{
    Console.WriteLine(3);
}
else if (user%8 == 0)
{
    Console.WriteLine(2);
}