using System.Text;

StringBuilder s = new StringBuilder();

string[] user = Console.ReadLine().Split();
string[] user2 = Console.ReadLine().Split();

int a = int.Parse(user[0]);
int b = int.Parse(user[1]);

for (int i = 0; i < user2.Length; i++)
{
    int m = int.Parse(user2[i]);
    if (m < b)
    {
        s.Append(m + " ");
    }
}
Console.WriteLine(s);