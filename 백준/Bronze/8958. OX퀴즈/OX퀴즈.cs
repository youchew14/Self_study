int num = int.Parse(Console.ReadLine());
string[] score = new string[num];

for (int i = 0; i < num; i++)
{
    score[i] = Console.ReadLine();
}
for (int i = 0; i < num; i++)
{
    int sum = 0;
    int result = 0;

    for (int j = 0; j < score[i].Length; j++)
    {
        if ((Char.ToString(score[i][j])).Equals("O"))
        {
            sum++;
            result += sum;
        }
        else
        {
            sum = 0;
        }
    }
    Console.WriteLine(result);
}