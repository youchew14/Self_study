using System.Text;

StringBuilder num = new StringBuilder();

int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n+1; i++)
{
    string[] user = Console.ReadLine().Split();
    int a = int.Parse(user[0]);
    int b = int.Parse(user[1]);

    num.Append("Case #" + i + ": " + (a + b) + "\n"); // 문자열로 저장된다.
}
Console.WriteLine(num.ToString());