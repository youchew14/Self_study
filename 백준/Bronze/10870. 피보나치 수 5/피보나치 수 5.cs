int user = int.Parse(Console.ReadLine()) + 1;
int[] num = new int[user + 1];

for (int i = 0; i < 2; i++)
{
    num[i] = i;
}
for (int i = 2; i < user; i++)
{
    num[i] = num[i - 1] + num[i - 2];
}
Console.WriteLine(num[user - 1]);