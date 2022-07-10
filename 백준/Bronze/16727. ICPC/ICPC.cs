string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

string[] user2 = Console.ReadLine().Split(' ');
int[] num2 = Array.ConvertAll(user2, int.Parse);

int p = num[0] + num2[1];
int e = num[1] + num2[0];

if (p > e)
{
    Console.WriteLine("Persepolis");
}
else if (p < e)
{
    Console.WriteLine("Esteghlal");
}
else
{
    if (num[0] < num2[0])
    {
        Console.WriteLine("Persepolis");
    }
    else if (num2[0] < num[0])
    {
        Console.WriteLine("Esteghlal");
    }
    else
    {
        Console.WriteLine("Penalty");
    }
}