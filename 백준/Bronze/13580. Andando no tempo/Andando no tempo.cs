string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

Array.Sort(num);

if (num[0] == num[1] || num[1] == num[2])
{
    Console.WriteLine("S");
}
else if (num[0] == num[1] - num[2])
{
    Console.WriteLine("S");
}
else if (num[0] + num[1] == num[2])
{
    Console.WriteLine("S");
}
else
{
    Console.WriteLine("N");
}