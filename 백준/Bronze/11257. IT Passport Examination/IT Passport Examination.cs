int user = int.Parse(Console.ReadLine());
string[] p = new string[user];

for (int i = 0; i < user; i++)
{
    string[] num = Console.ReadLine().Split(' ');
    int[] sco = Array.ConvertAll(num, int.Parse);

    int sum = sco[1] + sco[2] + sco[3];
    double a = 35 * 0.3;
    double b = 25 * 0.3;
    double c = 40 * 0.3;

    if (a <= (double)sco[1] && b <= (double)sco[2] && c <= (double)sco[3])
    {
        if (55 <= sum)
        {
            p[i] = num[0].ToString() + " " + sum.ToString() + " PASS";
        }
        else
        {
            p[i] = num[0].ToString() + " " + sum.ToString() + " FAIL";
        }
    }
    else
    {
        p[i] = num[0].ToString() + " " + sum.ToString() + " FAIL";
    }
}
Console.WriteLine(string.Join("\n", p));