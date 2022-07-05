int k = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if(k >= c)
{
    Console.WriteLine("Congratulations, you are within the speed limit!");
}
else if (k < c)
{
    if(c - k >= 1 && c - k <= 20)
    {
        Console.WriteLine("You are speeding and your fine is ${0}.", 100);
    }
    else if (c - k >= 21 && c - k <= 30)
    {
        Console.WriteLine("You are speeding and your fine is ${0}.", 270);
    }
    else
    {
        Console.WriteLine("You are speeding and your fine is ${0}.", 500);
    }
}