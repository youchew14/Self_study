string[] user = Console.ReadLine().Split(' ');
double[] num = Array.ConvertAll(user, double.Parse);

string[] user2 = Console.ReadLine().Split(' ');
double[] num2 = Array.ConvertAll(user2, double.Parse);

double P1 = num[0] / num[1];
double P2 = (num2[0] * num2[0] * Math.PI) / num2[1];

if (P1 > P2)
{
    Console.WriteLine("Slice of pizza");
}
else
{
    Console.WriteLine("Whole pizza");
}