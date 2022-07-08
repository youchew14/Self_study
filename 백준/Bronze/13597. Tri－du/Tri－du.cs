string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

if (num[0] == num[1])
{
    Console.WriteLine(num[0]);
}
else
{
    Console.WriteLine(Math.Max(num[0], num[1]));
}