int[] sco = new int[3];

for (int i = 0; i < 2; i++)
{
    string[] user = Console.ReadLine().Split(' ');
    int[] num = Array.ConvertAll(user, int.Parse);

    for (int j = 0; j < num.Length; j++)
    {
        sco[i] += num[j];
    }
}
Console.WriteLine(Math.Max(sco[0], sco[1]));