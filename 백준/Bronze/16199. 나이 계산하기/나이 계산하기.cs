string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

string[] day = Console.ReadLine().Split(' ');
int[] daynum = Array.ConvertAll(day, int.Parse);

int old = 0;

if (num[1] < daynum[1])
{
    old = daynum[0] - num[0];
}
else if (num[1] == daynum[1])
{
    if (num[2] <= daynum[2])
    {
        old = daynum[0] - num[0];
    }
    else
    {
        old = daynum[0] - num[0] - 1;
    }
}
else
{
    old = daynum[0] - num[0] - 1;
}
Console.WriteLine(old); // 만

Console.WriteLine(daynum[0] - num[0] + 1); // 세

Console.WriteLine(daynum[0] - num[0]); // 연