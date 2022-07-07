string[] user = Console.ReadLine().Split(' ');
int[] num = Array.ConvertAll(user, int.Parse);

int sum = num[0] + num[1] + num[2];
string[] schoole = { "Soongsil", "Korea", "Hanyang" };

if (sum >= 100)
{
    Console.WriteLine("OK");
}
else
{
    int m = Math.Min(num[0], Math.Min(num[1], num[2]));
    for (int i = 0; i < num.Length; i++)
    {
        if (m.ToString().Contains(num[i].ToString()))
        {
            Console.WriteLine(schoole[i]);
            break;
        }
    }
}