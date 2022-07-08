string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

if (num[0] == num[1] && num[1] != num[2])
{
    Console.WriteLine("C");
}
else if (num[1] == num[2] && num[0] != num[1])
{
    Console.WriteLine("A");
}
else if (num[0] == num[2] && num[0] != num[1])
{
    Console.WriteLine("B");
}
else if (num[0] == num[1] && num[1] == num[2])
{
    Console.WriteLine("*");
}