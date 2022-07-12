using System.Text;

string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

for (int i = 0; i < num.Length; i++)
{
    StringBuilder a = new StringBuilder();

    for (int j = num[i].ToString().Length - 1; j >= 0; j--)
    {
        a.Append(num[i].ToString()[j]);
    }
    num[i] = int.Parse(a.ToString());
}
num[0] = Math.Max(num[0], num[1]);
Console.WriteLine(num[0]);