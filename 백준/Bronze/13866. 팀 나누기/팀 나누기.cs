string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
int[] sco = new int[3];

sco[0] = Math.Abs((num[0] + num[1]) - (num[2] + num[3]));
sco[1] = Math.Abs((num[0] + num[2]) - (num[1] + num[3]));
sco[2] = Math.Abs((num[0] + num[3]) - (num[1] + num[2]));

int min = sco[0];

for (int i = 0; i < sco.Length; i++)
{
    if (min > sco[i])
    {
        min = sco[i];
    }
}
Console.WriteLine(min);