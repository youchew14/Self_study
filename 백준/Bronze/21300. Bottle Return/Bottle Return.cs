string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int re = 0;

for (int i = 0; i < 6; i++)
{
    re += num[i];
}
Console.WriteLine(re * 5);