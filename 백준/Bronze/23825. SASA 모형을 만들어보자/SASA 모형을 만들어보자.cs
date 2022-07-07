string[] user = Console.ReadLine().Split(" ");
double[] num = Array.ConvertAll(user, double.Parse);

if (num[0] >= 2 && num[1] >= 2)
{
    Console.WriteLine(Math.Min(Math.Truncate(num[0]/2) , Math.Truncate(num[1]/2)) );
}
else
{
    Console.WriteLine(0);
}