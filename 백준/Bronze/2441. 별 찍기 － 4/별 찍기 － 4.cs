using System.Text;

int user = int.Parse(Console.ReadLine());

StringBuilder s = new StringBuilder();
StringBuilder space = new StringBuilder();

for (int j = 0; j < user; j++)
{
    s.Append("*");
}
for (int i = user; i > 0; i--)
{
    Console.WriteLine("{0}{1}", space, s);
    space.Append(" ");
    s.Remove(i-1, 1);
}