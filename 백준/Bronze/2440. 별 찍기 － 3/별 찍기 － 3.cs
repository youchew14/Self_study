using System.Text;

int user = int.Parse(Console.ReadLine());
StringBuilder start = new StringBuilder();

for (int i = 0; i < user; i++)
{
    start.Append("*");
}
for (int i = user; i > 0; i--)
{
    Console.WriteLine(start.ToString());
    start.Remove(i-1, 1);
}