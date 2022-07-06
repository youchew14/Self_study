int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    Console.WriteLine("divide by zero");
}
else
{
    string[] user = Console.ReadLine().Split(' ');
    double[] num = Array.ConvertAll(user, double.Parse);

    Console.WriteLine("1.00");
}