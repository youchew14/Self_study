string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int count = 0;

while(true)
{
    if (num[0] < num[1])
    {
        num[0] += num[2];
        count++;
    }
    if (num[0] >= num[1]) break;
}
Console.WriteLine(count);