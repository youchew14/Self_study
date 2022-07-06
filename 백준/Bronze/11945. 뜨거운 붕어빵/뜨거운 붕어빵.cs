string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);
string[] fish = new string[num[0]];

for (int i = 0; i < num[0]; i++)
{
    string seq = Console.ReadLine();
    string t = null;

    for (int j = seq.Length - 1; j >= 0; j--)
    {
        t += seq[j].ToString();
    }
    fish[i] = t;
}
Console.WriteLine(string.Join("\n", fish));