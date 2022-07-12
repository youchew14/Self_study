using System.Text;

int user = int.Parse(Console.ReadLine());

StringBuilder s = new StringBuilder();
StringBuilder ss = new StringBuilder();

for (int i = 0; i < 2 * user - 1; i++)
{
    s.Append("*");
}
for (int i = user - 1; i > 0; i--)
{
    Console.WriteLine("{0}{1}", ss, s);
    ss.Append(" ");
    if (s.Length != 1)
    {
        s.Remove(0, 1);
        s.Remove(s.Length - 1, 1);
    }
}
s.Remove(0, 1);
for (int i = 0; i < user; i++)
{
    s.Append("*");
    Console.WriteLine("{0}{1}", ss, s);

    if (ss.Length != 0)
    {
        ss.Remove(0, 1);
    }
    for (int j = 1; j < 2; j++)
    {
        s.Append("*");
    }
}