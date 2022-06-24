using System.Text;

StringBuilder start = new StringBuilder();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    start.Append("*");
    Console.WriteLine(start.ToString());
}