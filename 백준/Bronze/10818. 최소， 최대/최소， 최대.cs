int len = int.Parse(Console.ReadLine());
string[] user = Console.ReadLine().Split();
int[] num = new int[len];

for (int i = 0; i < len; i++)
{
    num[i] = int.Parse(user[i]);
}
int min = num[num.Length - 1];
int max = num[num.Length - 1];

for (int i = 0; i < num.Length; i++)
{
    if (min >= num[i])
    {
        min = num[i];
    }
    if (max <= num[i])
    {
        max = num[i];
    }
}
Console.WriteLine(min + " " + max);