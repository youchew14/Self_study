string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);
double a = (num[0] * num[1]) / num[2];
double b = (num[0] / num[1]) * num[2];

if (a > b)
{
    Console.WriteLine((int)a);
}
else
{
    Console.WriteLine((int)b);
}