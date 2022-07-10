string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int c = num[0] * num[1];
int s = num[2] * num[3];

if (c > s && num[0] - num[2] > 1 && num[1] - num[3] > 1)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}