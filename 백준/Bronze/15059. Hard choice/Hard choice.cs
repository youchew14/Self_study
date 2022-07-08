string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

string[] user2 = Console.ReadLine().Split(' ');
int[] num2 = Array.ConvertAll(user2, int.Parse);

int count = 0;

if (num[0] < num2[0])
{
    count += Math.Abs(num[0] - num2[0]);
}
if (num[1] < num2[1])
{
    count += Math.Abs(num[1] - num2[1]);
}
if (num[2] < num2[2])
{
    count += Math.Abs(num[2] - num2[2]);
}
Console.WriteLine(count);