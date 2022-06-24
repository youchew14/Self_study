using System.Text;

StringBuilder start = new StringBuilder();
StringBuilder space = new StringBuilder();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    space.Append(" ");
}
for (int i = 0; i < n; i++)
{
    start.Append("*");
    space.Remove(0, 1);

    Console.WriteLine(space + start.ToString());
}