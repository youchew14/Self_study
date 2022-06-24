using System.Text;

StringBuilder s = new StringBuilder();

while (true)
{
    string[] user = Console.ReadLine().Split();

    int a = int.Parse(user[0]);
    int b = int.Parse(user[1]);

    if (a == 0 && b == 0)
    {
        break;
    }
    Console.WriteLine(a + b);
}