string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
Array.Sort(num);

if (num[0] == num[1] && num[1] == num[2])
{
    Console.WriteLine(2);
}
else if (num[2] * num[2] == (num[0] * num[0]) + (num[1] * num[1]))
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}