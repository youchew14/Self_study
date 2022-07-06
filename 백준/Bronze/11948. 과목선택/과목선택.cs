int[] sco = new int[6];

for (int i = 0; i < 6; i++)
{
    sco[i] = int.Parse(Console.ReadLine());
}
int sum = sco[0] + sco[1] + sco[2] + sco[3];
int min = Math.Min(sco[0], Math.Min(sco[1], Math.Min(sco[2], sco[3])));
int max =(sum - min) + Math.Max(sco[4], sco[5]);

Console.WriteLine(max);