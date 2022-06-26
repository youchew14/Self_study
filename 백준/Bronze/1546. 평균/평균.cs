int num = int.Parse(Console.ReadLine());
string[] u_score = Console.ReadLine().Split();

int[] score = new int[u_score.Length];
double[] lie = new double[score.Length];
int max = 0;
double sum = 0;

for (int i = 0; i < num; i++)
{
    score[i] = int.Parse(u_score[i]);

    if (max <= score[i])
    {
        max = score[i];
    }
}
for (int i = 0; i < score.Length; i++)
{
    lie[i] = (double)score[i] / (double)max * 100;
}
for (int i = 0; i < lie.Length; i++)
{
    sum += lie[i];
}
Console.WriteLine(sum/num);